using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ComeCommonMethod
{
    public class AnimatedRectDrawer
    {
        public class DrawInfoItem
        {
            /// <summary>
            /// 原始控件
            /// 
            /// Source Control
            /// </summary>
            public System.Windows.Forms.Control SourceControl = null;
            /// <summary>
            /// 原始区域
            /// 
            /// Source Rectangle
            /// </summary>
            public System.Drawing.Rectangle SourceRect = System.Drawing.Rectangle.Empty;
            /// <summary>
            /// 目标窗体
            /// 
            /// Desc Form object
            /// </summary>
            public System.Windows.Forms.Form Form = null;
            /// <summary>
            /// 对象额外数据
            /// 
            /// object's extern data
            /// </summary>
            public object Tag = null;
        }


        public AnimatedRectDrawer()
        {
            _FormClosed = new System.EventHandler(Form_Closed);
            _FormLoad = new EventHandler(Form_Load);
        }
        public DrawInfoItem Add(System.Windows.Forms.Control ctl, System.Drawing.Rectangle rect, System.Windows.Forms.Form frm)
        {
            DrawInfoItem item = GetItem(frm);
            if (item == null)
            {
                item = new DrawInfoItem();
                myItems.Add(item);
                frm.Load += _FormLoad;

                frm.Closed += _FormClosed;
            }
            item.SourceControl = ctl;
            item.SourceRect = rect;
            item.Form = frm;
            return item;
        }
        public DrawInfoItem Add(System.Windows.Forms.Control ctl, System.Windows.Forms.Form frm)
        {
            return Add(ctl, System.Drawing.Rectangle.Empty, frm);
        }
        /// <summary>
        /// 删除所有项目
        /// </summary>
        public void Clear()
        {
            myItems.Clear();
        }
        public DrawInfoItem GetItem(System.Windows.Forms.Form frm)
        {
            foreach (DrawInfoItem item in myItems)
            {
                if (item.Form == frm)
                    return item;
            }
            return null;
        }

        #region 内部代码群 Internal code **************************************

        private System.Collections.ArrayList myItems = new System.Collections.ArrayList();
        private System.EventHandler _FormClosed = null;

        private System.EventHandler _FormLoad = null;

        private void Form_Load(object sender, System.EventArgs e)
        {
            DrawInfoItem item = GetItem((System.Windows.Forms.Form)sender);
            if (item != null)
            {
                InnerDraw(item, true);
            }

        }


        private void Form_Closed(object sender, System.EventArgs e)
        {
            DrawInfoItem myItem = GetItem((System.Windows.Forms.Form)sender);
            if (myItem != null)
            {
                myItems.Remove(myItem);
                InnerDraw(myItem, false);
            }
        }

        private void InnerDraw(DrawInfoItem item, bool bolOpen)
        {
            if (item == null)
                return;

            if (item.SourceControl == null || item.Form == null)
                return;

            System.Drawing.Rectangle srect = this.GetScreenRect(
                item.SourceRect,
                item.SourceControl);

            if (srect.IsEmpty)
                return;

            System.Drawing.Rectangle trect = this.GetScreenRect(
                System.Drawing.Rectangle.Empty,
                item.Form);

            if (trect.IsEmpty)
                return;

            RECT rect1 = new RECT();
            rect1.left = srect.Left;
            rect1.top = srect.Top;
            rect1.right = srect.Right;
            rect1.bottom = srect.Bottom;

            RECT rect2 = new RECT();
            rect2.left = trect.Left;
            rect2.top = trect.Top;
            rect2.right = trect.Right;
            rect2.bottom = trect.Bottom;

            if (bolOpen)
                DrawAnimatedRects(item.Form.Handle, IDANI_CAPTION, ref rect1, ref rect2);
            else
                DrawAnimatedRects(item.Form.Handle, IDANI_CAPTION, ref rect2, ref rect1);
        }

        private System.Drawing.Rectangle GetScreenRect(
            System.Drawing.Rectangle rect,
            System.Windows.Forms.Control ctl)
        {
            System.Drawing.Rectangle result = System.Drawing.Rectangle.Empty;
            if (ctl == null)
            {
                result = rect;
            }
            else
            {
                result = GetControlBounds(ctl);
                if (rect.IsEmpty)
                    result = GetControlBounds(ctl);
                else
                {
                    result = rect;
                    result.Location = ctl.PointToScreen(result.Location);
                }
            }
            return result;
        }
        /// <summary>
        /// 获得控件在屏幕中的矩形区域 get a control's bounds in screeen
        /// </summary>
        /// <param name="ctl">控件对象 control instance</param>
        /// <returns>矩形区域对象 bounds in screen</returns>
        private System.Drawing.Rectangle GetControlBounds(System.Windows.Forms.Control ctl)
        {
            if (ctl == null)
                return System.Drawing.Rectangle.Empty;
            if (ctl.IsHandleCreated)
            {
                RECT rect = new RECT();
                if (GetWindowRect(ctl.Handle, ref rect))
                {
                    return new System.Drawing.Rectangle(
                        rect.left,
                        rect.top,
                        rect.right - rect.left,
                        rect.bottom - rect.top);
                }
            }
            return ctl.Bounds;
        }

        #endregion

        #region 声明Win32API函数以及结构 declare Win32API function and structure

        private const int IDANI_CAPTION = 0x3;
        private const int IDANI_CLOSE = 0x2;
        private const int IDANI_OPEN = 0x1;


        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool DrawAnimatedRects(
            IntPtr hwnd,
            int Ani,
            ref RECT from,
            ref RECT to);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hwnd, ref RECT rect);

        #endregion
    }
}
