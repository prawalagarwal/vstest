﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.Common
{
    using System;

    using Microsoft.VisualStudio.TestPlatform.Common.Interfaces.Engine;
    using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;

    /// <summary>
    /// Provide common services and data for a discovery/run request.
    /// </summary>
    public class RequestData : IRequestData
    {
        private IMetricsCollection metricsCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestData"/> class.
        /// </summary>
        /// <param name="metricsCollection">
        /// The metrics collection.
        /// </param>
        public RequestData(IMetricsCollection metricsCollection)
        {
            this.metricsCollection = metricsCollection ?? throw new ArgumentNullException(nameof(metricsCollection));
        }

        /// <inheritdoc/>
        public IMetricsCollection MetricsCollection => this.metricsCollection;
    }
}
