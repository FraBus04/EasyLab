window.checkboxDropdownInterop = {
    _scrollHandler: null,

    getRect: function (el) {
        if (!el) return null;
        var r = el.getBoundingClientRect();
        return { left: r.left, top: r.bottom, width: r.width };
    },

    watchClose: function (dotNetRef) {
        this.unwatchClose();
        this._scrollHandler = function (e) {
            // Scrolling inside the open menu's own item list must not close it.
            var t = e.target;
            if (t && t.nodeType === 1 && t.closest('.checkbox-dropdown-menu')) {
                return;
            }
            dotNetRef.invokeMethodAsync('OnOutsideScrollOrResize');
        };
        window.addEventListener('scroll', this._scrollHandler, true);
        window.addEventListener('resize', this._scrollHandler);
    },

    unwatchClose: function () {
        if (this._scrollHandler) {
            window.removeEventListener('scroll', this._scrollHandler, true);
            window.removeEventListener('resize', this._scrollHandler);
            this._scrollHandler = null;
        }
    }
};
