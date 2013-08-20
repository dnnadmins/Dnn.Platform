#region Copyright
// 
// DotNetNuke� - http://www.dotnetnuke.com
// Copyright (c) 2002-2013
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion
#region Usings

using System;

#endregion

namespace DotNetNuke.Entities.Users
{
    /// -----------------------------------------------------------------------------
    /// Project:    DotNetNuke
    /// Namespace:  DotNetNuke.Entities.Users
    /// Class:      OnlineUserInfo
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The OnlineUserInfo class provides an Entity for an online user
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    ///     [cnurse]	03/14/2006	documented
    /// </history>
    /// -----------------------------------------------------------------------------
    [Serializable]
    public class OnlineUserInfo : BaseUserInfo
    {
        private int _UserID;

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Gets and sets the User Id for this online user
        /// </summary>
        /// <history>
        ///     [cnurse]	03/14/2006	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
    }
}