// Copyright 2016 by Samsung Electronics, Inc.,
//
// This software is the confidential and proprietary information
// of Samsung Electronics, Inc. ("Confidential Information"). You
// shall not disclose such Confidential Information and shall use
// it only in accordance with the terms of the license agreement
// you entered into with Samsung.

using System;
using Tizen.UI;

namespace Tizen.Applications
{
    /// <summary>
    /// Abstract class for widget instances
    /// </summary>
    public abstract class WidgetBase
    {
        internal IntPtr Handle;
        internal string Id;
        protected static readonly string LogTag = typeof(WidgetBase).Namespace;

        /// <summary>
        /// The main window instance of the widget instance.
        /// </summary>
        public Window Window { get; private set; }

        /// <summary>
        /// Delete type
        /// </summary>
        public enum WidgetDestroyType
        {
            /// <summary>
            /// User deleted this widget from the viewer.
            /// </summary>
            Permanent = 0,

            /// <summary>
            /// Widget is deleted because of other reasons. (e.g. widget process is terminated temporarily by the system)
            /// </summary>
            Temporary
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public WidgetBase()
        {
        }

        /// <summary>
        /// Sets the content info to the widget.
        /// </summary>
        /// <param name="info">The data set to save</param>
        /// <exception cref="ArgumentException">Thrown when failed because of invalid argument</exception>
        /// <exception cref="NotSupportedException">Thrown when API is not supported in this device</exception>
        /// <exception cref="InvalidOperationException">Thrown in case of unrecoverable error</exception>
        public void SetContent(Bundle info)
        {
            Interop.Widget.ErrorCode err = Interop.Widget.SetContent(Handle, info.SafeBundleHandle);

            if (err != Interop.Widget.ErrorCode.None)
            {
                Log.Error(LogTag, "Failed to set content. Err = " + err);

                switch(err)
                {
                    case Interop.Widget.ErrorCode.InvalidParameter:
                        throw new ArgumentException("Invalid parameter of SetContent()");

                    case Interop.Widget.ErrorCode.NotSupported:
                        throw new NotSupportedException();

                    case Interop.Widget.ErrorCode.OutOfMemory:
                    case Interop.Widget.ErrorCode.Fault:
                        throw new InvalidOperationException();
                }

            }
        }

        /// <summary>
        /// Sends the title to the widget.
        /// </summary>
        /// <param name="title">When an accessibility mode is turned on, this string will be read</param>
        /// <exception cref="ArgumentException">Thrown when failed because of invalid argument</exception>
        /// <exception cref="NotSupportedException">Thrown when API is not supported in this device</exception>
        /// <exception cref="InvalidOperationException">Thrown in case of unrecoverable error</exception>
        public void SetTitle(string title)
        {
            Interop.Widget.ErrorCode err = Interop.Widget.SetTitle(Handle, title);

            if (err != Interop.Widget.ErrorCode.None)
            {
                Log.Error(LogTag, "Failed to set title. Err = " + err);

                switch (err)
                {
                    case Interop.Widget.ErrorCode.InvalidParameter:
                        throw new ArgumentException("Invalid parameter of SetContent()");

                    case Interop.Widget.ErrorCode.NotSupported:
                        throw new NotSupportedException();

                    case Interop.Widget.ErrorCode.OutOfMemory:
                    case Interop.Widget.ErrorCode.Fault:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Finishes context for the widget instance.
        /// </summary>
        /// <exception cref="NotSupportedException">Thrown when API is not supported in this device</exception>
        /// <exception cref="InvalidOperationException">Thrown in case of unrecoverable error</exception>
        public void Exit()
        {
            Interop.Widget.ErrorCode err = Interop.Widget.TerminateContext(Handle);

            if (err != Interop.Widget.ErrorCode.None)
            {
                Log.Error(LogTag, "Failed to terminate context. Err = " + err);

                switch (err)
                {
                    case Interop.Widget.ErrorCode.NotSupported:
                        throw new NotSupportedException();

                    case Interop.Widget.ErrorCode.InvalidParameter:
                    case Interop.Widget.ErrorCode.Fault:
                        throw new InvalidOperationException();
                }
            }
        }

        internal void Bind(IntPtr handle, string id)
        {
            Handle = handle;
            Id = id;
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance is started.
        /// </summary>
        /// <param name="content">The data set for the previous status</param>
        /// <param name="w">The pixel value for widget width</param>
        /// <param name="h">The pixel value for widget height</param>
        public virtual void OnCreate(Bundle content, int w, int h)
        {
            IntPtr win;

            Interop.Widget.GetWin(Handle, out win);

            //TODO: convert win to an instance of Window
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance is destroyed.
        /// </summary>
        /// <param name="reason">The reason for destruction</param>
        /// <param name="content">The data set to save</param>
        public virtual void OnDestroy(WidgetDestroyType reason, Bundle content)
        {
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance is paused.
        /// </summary>
        public virtual void OnPause()
        {
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance is resumed.
        /// </summary>
        public virtual void OnResume()
        {
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance is resized.
        /// </summary>
        /// <param name="w">Widget width</param>
        /// <param name="h">Widget height</param>
        public virtual void OnResize(int w, int h)
        {
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the widget instance should be updated.
        /// </summary>
        /// <param name="content">The data set for updating this widget. It will be provided by requester.</param>
        /// <param name="isForce">Although the widget is paused, if it is TRUE, the widget can be updated</param>
        public virtual void OnUpdate(Bundle content, bool isForce)
        {
        }
    }
}
