// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel.Client
{
    using System;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

    /// <summary>
    /// The request that a RunTests API returns.
    /// </summary>
    public interface ITestRunRequest : IRequest
    {
        /// <summary>
        /// Start the current RunTestAsync API call.
        /// </summary>
        /// <returns>Id of the executor process </returns>
        int ExecuteAsync();

        /// <summary>
        ///  Cancel the current RunTestsAsync API call. This can be used when  making async RunTestsAsync call.
        /// </summary>
        void CancelAsync();

        /// <summary>
        ///  Aborts the test run execution process.
        /// </summary>
        void Abort();

        /// <summary>
        /// Specifies the test run criteria
        /// </summary>
        ITestRunConfiguration TestRunConfiguration
        {
            get;
        }

        /// <summary>
        /// State of the test run
        /// </summary>
        TestRunState State { get; }

        /// <summary>
        ///  Handler for notifying when test results came back from the agent!
        /// </summary>
        event EventHandler<TestRunChangedEventArgs> OnRunStatsChange;

        /// <summary>
        ///  Handler for notifying test run is complete
        /// </summary>
        event EventHandler<TestRunCompleteEventArgs> OnRunCompletion;

        /// <summary>
        ///  Handler for receiving error during fetching/execution. This is used for when abnormal error 
        ///  occurs; equivalent of IRunMessageLogger in the current RockSteady core
        /// </summary>
        event EventHandler<TestRunMessageEventArgs> TestRunMessage;

        /// <summary>
        ///  Handler for receiving data collection messages.
        /// </summary>
        event EventHandler<DataCollectionMessageEventArgs> DataCollectionMessage;
    }
}