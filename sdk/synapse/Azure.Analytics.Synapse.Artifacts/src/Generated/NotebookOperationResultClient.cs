// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The NotebookOperationResult service client. </summary>
    public partial class NotebookOperationResultClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NotebookOperationResultRestClient RestClient { get; }

        /// <summary> Initializes a new instance of NotebookOperationResultClient for mocking. </summary>
        protected NotebookOperationResultClient()
        {
        }

        /// <summary> Initializes a new instance of NotebookOperationResultClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public NotebookOperationResultClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new NotebookOperationResultRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of NotebookOperationResultClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal NotebookOperationResultClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new NotebookOperationResultRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get notebook operation result. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookOperationResultClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(operationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get notebook operation result. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Get(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebookOperationResultClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(operationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
