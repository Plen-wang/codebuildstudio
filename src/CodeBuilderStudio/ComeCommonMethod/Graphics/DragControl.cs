using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ComeCommonMethod.Graphics
{
    /// <summary>
    /// 控件拖拽类
    /// </summary>
    public class DragControl
    {
        private Control _drag = null;
        private Control _move = null;
        private Cursor _oldCursor = null;

        private int initialX;
        private int initialY;

        private DragControl() { }
        public DragControl(Control drag, Control move)
        {
            _drag = drag;
            _move = move;
        }
        public DragControl(Control dragControl) : this(dragControl, dragControl) { }

        public void CloseDrag()
        {
            _drag.Cursor = _oldCursor;
            _drag.MouseDown -= MoveTipDown;
        }

        public void OpenDrag()
        {
            _oldCursor = _drag.Cursor;
            _drag.Cursor = Cursors.SizeAll;
            _drag.MouseDown += MoveTipDown;
        }

        private void MoveTipDown(object sender, MouseEventArgs e)
        {
            initialX = e.X;
            initialY = e.Y;
            _drag.MouseMove += MoveTipMove;
            _drag.MouseUp += MoveTipUp;
        }

        private void MoveTipUp(object sender, MouseEventArgs e)
        {
            _drag.MouseMove -= MoveTipMove;
            _drag.MouseUp -= MoveTipUp;
        }

        private void MoveTipMove(object sender, MouseEventArgs e)
        {
            if (e.Y != initialY) _move.Top = _move.Top + (e.Y - initialY);
            if (e.X != initialX) _move.Left = _move.Left + (e.X - initialX);
        }
    }
}
