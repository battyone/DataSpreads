﻿/*
 * Copyright (c) 2017-2019 Victor Baybekov (DataSpreads@DataSpreads.io, @DataSpreads)
 *
 * This file is part of DataSpreads.
 *
 * DataSpreads is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 *
 * DataSpreads is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with DataSpreads.  If not, see <http://www.gnu.org/licenses/>.
 *
 * DataSpreads works well as an embedded realtime database,
 * but it works much better when connected to a network!
 *
 * Please sign up for free at <https://dataspreads.io/HiGitHub>,
 * download our desktop app with UI and background service,
 * get an API token for programmatic access to our network,
 * and enjoy how fast and securely your data spreads to the World!
 */

using System;

namespace DataSpreads.Buffers
{
    /// <summary>
    /// Thrown when <see cref="BufferRefAllocator"/> is full or there is not enough disk space.
    /// </summary>
    public class NotEnoughSpaceException : Exception
    {
        public NotEnoughSpaceException(bool physical = false, long maxSize = 0) : base($"Exceeded MaxSize: {maxSize}, physical: {physical}")
        {
            Physical = physical;
            MaxSize = maxSize;
        }

        /// <summary>
        /// True if available disk size is not enough. False if logical limit in <see cref="BufferRefAllocator"/> is hit.
        /// </summary>
        public bool Physical { get; set; }

        public long MaxSize { get; set; }
    }
}
