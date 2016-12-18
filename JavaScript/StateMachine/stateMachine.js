var stateMachine = (function () {
    var pending = 0,
        fulfilled = 1,
        rejected = 2;

    function Promise(fn) {
        var state = pendign;
        var value = null;
        var handlers = [];

        function fullfill(result) {
            state = fulfilled;
            value = result;
        }

        function reject(error) {
            state = rejected;
            value = error;
        }

        function resolve(result) {
            try {
                var then = getThen(result);

                if (then) {
                    doResolve(then.bind(result), resolve, reject);
                    return;
                }

                fullfill(result);
            } catch (e) {
                reject(e);
            }
        }

        doResolve(fn, onFulfilled, onRejected);
    }

    function getThen(value) {
        var t = typeof value;

        if (value && (t === 'object' || t === 'function')) {
            var then = value.then;
            if (typeof then === 'function') {
                return then;
            }
        }

        return null;
    }

    function doResolve(fn, onFulfilled, onRejected) {
        var done = false;

        try {
            fn(function (value) {
                if (done)
                    return;

                done = true;
                onFulfilled(value);
            },
                function (reason) {
                    if (done)
                        return;

                    done = true;
                    onRejected(reason);
                });
        } catch (e) {
            if (done)
                return;

            done = true;
            onRejected(e);
        }
    }
});

// TODO: https://www.promisejs.org/implementing/#constructing