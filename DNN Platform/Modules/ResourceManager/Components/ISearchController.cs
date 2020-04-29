﻿#region Copyright
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2018
// by DotNetNuke Corporation
// All Rights Reserved
#endregion

using System;
using System.Collections.Generic;
using DotNetNuke.Services.FileSystem;
using DotNetNuke.Services.Search.Entities;

namespace Dnn.Modules.ResourceManager.Components
{
    public interface ISearchController
    {
        /// <summary>
        /// Performs the Advanced File Search
        /// </summary>
        /// <param name="moduleId">The id of the Module</param>
        /// <param name="folder">Folder that defines the context of the search</param>
        /// <param name="recursive">Include subfolders in search</param>
        /// <param name="search">Search query</param>
        /// <param name="pageIndex">page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="sorting">sorting</param>
        /// <param name="moduleMode">Module Mode.</param>
        /// <param name="totalCount">total count.</param>
        /// <returns>Result set of the File Search</returns>
        IList<IFileInfo> SearchFolderContent(int moduleId, IFolderInfo folder, bool recursive, string search,
            int pageIndex, int pageSize, string sorting, int moduleMode, out int totalCount);
    }
}
