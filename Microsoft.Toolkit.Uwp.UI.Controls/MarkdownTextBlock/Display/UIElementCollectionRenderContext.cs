﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Toolkit.Parsers.Markdown.Display;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Markdown.Display
{
    internal class UIElementCollectionRenderContext : RenderContext
    {
        internal UIElementCollectionRenderContext(UIElementCollection blockUIElementCollection)
        {
            BlockUIElementCollection = blockUIElementCollection;
        }

        internal UIElementCollectionRenderContext(UIElementCollection blockUIElementCollection, IRenderContext context)
            : this(blockUIElementCollection)
        {
            Foreground = ((RenderContext)context).Foreground;
            TrimLeadingWhitespace = context.TrimLeadingWhitespace;
            Parent = context.Parent;
        }

        /// <summary>
        /// Gets or sets the list to add to.
        /// </summary>
        public UIElementCollection BlockUIElementCollection { get; set; }
    }
}