﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AspNetCoreSdkTests.Templates
{
    public class RazorClassLibraryTemplate : ClassLibraryTemplate
    {
        public RazorClassLibraryTemplate() { }

        public override string Name => "razorclasslib";

        public override IEnumerable<string> ExpectedObjFilesAfterBuild =>
            base.ExpectedObjFilesAfterBuild
                .Concat(RazorUtil.GetExpectedObjFilesAfterBuild(this))
                .Concat(new[]
                    {
                        Path.Combine("Razor", "Areas", "MyFeature", "Pages", "Page1.g.cshtml.cs"),
                    }.Select(p => Path.Combine(OutputPath, p)));

        // We set PreserveCompilationContext=true for all project types in the Razor.Sdk. This results in an refs directory to be created
        // in the build output directory which is undesirable. We should consider setting PreserveCompilationContext=true only if the
        // app's an executable.
        // https://github.com/aspnet/Razor/issues/2308
        public override IEnumerable<string> ExpectedBinFilesAfterBuild =>
            base.ExpectedBinFilesAfterBuild
            .Concat(RazorUtil.GetExpectedBinFilesAfterBuild(this))
            .Concat(new[]
            {
                Path.Combine("refs", "Microsoft.Win32.Primitives.dll"),
                Path.Combine("refs", "mscorlib.dll"),
                Path.Combine("refs", "netstandard.dll"),
                Path.Combine("refs", "System.AppContext.dll"),
                Path.Combine("refs", "System.Collections.Concurrent.dll"),
                Path.Combine("refs", "System.Collections.dll"),
                Path.Combine("refs", "System.Collections.NonGeneric.dll"),
                Path.Combine("refs", "System.Collections.Specialized.dll"),
                Path.Combine("refs", "System.ComponentModel.Composition.dll"),
                Path.Combine("refs", "System.ComponentModel.dll"),
                Path.Combine("refs", "System.ComponentModel.EventBasedAsync.dll"),
                Path.Combine("refs", "System.ComponentModel.Primitives.dll"),
                Path.Combine("refs", "System.ComponentModel.TypeConverter.dll"),
                Path.Combine("refs", "System.Console.dll"),
                Path.Combine("refs", "System.Core.dll"),
                Path.Combine("refs", "System.Data.Common.dll"),
                Path.Combine("refs", "System.Data.dll"),
                Path.Combine("refs", "System.Diagnostics.Contracts.dll"),
                Path.Combine("refs", "System.Diagnostics.Debug.dll"),
                Path.Combine("refs", "System.Diagnostics.FileVersionInfo.dll"),
                Path.Combine("refs", "System.Diagnostics.Process.dll"),
                Path.Combine("refs", "System.Diagnostics.StackTrace.dll"),
                Path.Combine("refs", "System.Diagnostics.TextWriterTraceListener.dll"),
                Path.Combine("refs", "System.Diagnostics.Tools.dll"),
                Path.Combine("refs", "System.Diagnostics.TraceSource.dll"),
                Path.Combine("refs", "System.Diagnostics.Tracing.dll"),
                Path.Combine("refs", "System.dll"),
                Path.Combine("refs", "System.Drawing.dll"),
                Path.Combine("refs", "System.Drawing.Primitives.dll"),
                Path.Combine("refs", "System.Dynamic.Runtime.dll"),
                Path.Combine("refs", "System.Globalization.Calendars.dll"),
                Path.Combine("refs", "System.Globalization.dll"),
                Path.Combine("refs", "System.Globalization.Extensions.dll"),
                Path.Combine("refs", "System.IO.Compression.dll"),
                Path.Combine("refs", "System.IO.Compression.FileSystem.dll"),
                Path.Combine("refs", "System.IO.Compression.ZipFile.dll"),
                Path.Combine("refs", "System.IO.dll"),
                Path.Combine("refs", "System.IO.FileSystem.dll"),
                Path.Combine("refs", "System.IO.FileSystem.DriveInfo.dll"),
                Path.Combine("refs", "System.IO.FileSystem.Primitives.dll"),
                Path.Combine("refs", "System.IO.FileSystem.Watcher.dll"),
                Path.Combine("refs", "System.IO.IsolatedStorage.dll"),
                Path.Combine("refs", "System.IO.MemoryMappedFiles.dll"),
                Path.Combine("refs", "System.IO.Pipes.dll"),
                Path.Combine("refs", "System.IO.UnmanagedMemoryStream.dll"),
                Path.Combine("refs", "System.Linq.dll"),
                Path.Combine("refs", "System.Linq.Expressions.dll"),
                Path.Combine("refs", "System.Linq.Parallel.dll"),
                Path.Combine("refs", "System.Linq.Queryable.dll"),
                Path.Combine("refs", "System.Net.dll"),
                Path.Combine("refs", "System.Net.Http.dll"),
                Path.Combine("refs", "System.Net.NameResolution.dll"),
                Path.Combine("refs", "System.Net.NetworkInformation.dll"),
                Path.Combine("refs", "System.Net.Ping.dll"),
                Path.Combine("refs", "System.Net.Primitives.dll"),
                Path.Combine("refs", "System.Net.Requests.dll"),
                Path.Combine("refs", "System.Net.Security.dll"),
                Path.Combine("refs", "System.Net.Sockets.dll"),
                Path.Combine("refs", "System.Net.WebHeaderCollection.dll"),
                Path.Combine("refs", "System.Net.WebSockets.Client.dll"),
                Path.Combine("refs", "System.Net.WebSockets.dll"),
                Path.Combine("refs", "System.Numerics.dll"),
                Path.Combine("refs", "System.ObjectModel.dll"),
                Path.Combine("refs", "System.Reflection.dll"),
                Path.Combine("refs", "System.Reflection.Extensions.dll"),
                Path.Combine("refs", "System.Reflection.Primitives.dll"),
                Path.Combine("refs", "System.Resources.Reader.dll"),
                Path.Combine("refs", "System.Resources.ResourceManager.dll"),
                Path.Combine("refs", "System.Resources.Writer.dll"),
                Path.Combine("refs", "System.Runtime.CompilerServices.VisualC.dll"),
                Path.Combine("refs", "System.Runtime.dll"),
                Path.Combine("refs", "System.Runtime.Extensions.dll"),
                Path.Combine("refs", "System.Runtime.Handles.dll"),
                Path.Combine("refs", "System.Runtime.InteropServices.dll"),
                Path.Combine("refs", "System.Runtime.InteropServices.RuntimeInformation.dll"),
                Path.Combine("refs", "System.Runtime.Numerics.dll"),
                Path.Combine("refs", "System.Runtime.Serialization.dll"),
                Path.Combine("refs", "System.Runtime.Serialization.Formatters.dll"),
                Path.Combine("refs", "System.Runtime.Serialization.Json.dll"),
                Path.Combine("refs", "System.Runtime.Serialization.Primitives.dll"),
                Path.Combine("refs", "System.Runtime.Serialization.Xml.dll"),
                Path.Combine("refs", "System.Security.Claims.dll"),
                Path.Combine("refs", "System.Security.Cryptography.Algorithms.dll"),
                Path.Combine("refs", "System.Security.Cryptography.Csp.dll"),
                Path.Combine("refs", "System.Security.Cryptography.Encoding.dll"),
                Path.Combine("refs", "System.Security.Cryptography.Primitives.dll"),
                Path.Combine("refs", "System.Security.Cryptography.X509Certificates.dll"),
                Path.Combine("refs", "System.Security.Principal.dll"),
                Path.Combine("refs", "System.Security.SecureString.dll"),
                Path.Combine("refs", "System.ServiceModel.Web.dll"),
                Path.Combine("refs", "System.Text.Encoding.dll"),
                Path.Combine("refs", "System.Text.Encoding.Extensions.dll"),
                Path.Combine("refs", "System.Text.RegularExpressions.dll"),
                Path.Combine("refs", "System.Threading.dll"),
                Path.Combine("refs", "System.Threading.Overlapped.dll"),
                Path.Combine("refs", "System.Threading.Tasks.dll"),
                Path.Combine("refs", "System.Threading.Tasks.Parallel.dll"),
                Path.Combine("refs", "System.Threading.Thread.dll"),
                Path.Combine("refs", "System.Threading.ThreadPool.dll"),
                Path.Combine("refs", "System.Threading.Timer.dll"),
                Path.Combine("refs", "System.Transactions.dll"),
                Path.Combine("refs", "System.ValueTuple.dll"),
                Path.Combine("refs", "System.Web.dll"),
                Path.Combine("refs", "System.Windows.dll"),
                Path.Combine("refs", "System.Xml.dll"),
                Path.Combine("refs", "System.Xml.Linq.dll"),
                Path.Combine("refs", "System.Xml.ReaderWriter.dll"),
                Path.Combine("refs", "System.Xml.Serialization.dll"),
                Path.Combine("refs", "System.Xml.XDocument.dll"),
                Path.Combine("refs", "System.Xml.XmlDocument.dll"),
                Path.Combine("refs", "System.Xml.XmlSerializer.dll"),
                Path.Combine("refs", "System.Xml.XPath.dll"),
                Path.Combine("refs", "System.Xml.XPath.XDocument.dll"),
            }.Select(p => Path.Combine(OutputPath, p)));

        private IEnumerable<string> _additionalFilesAfterPublishCommon = new[]
        {
            "Microsoft.AspNetCore.Antiforgery.dll",
            "Microsoft.AspNetCore.Authentication.Abstractions.dll",
            "Microsoft.AspNetCore.Authentication.Core.dll",
            "Microsoft.AspNetCore.Authorization.dll",
            "Microsoft.AspNetCore.Authorization.Policy.dll",
            "Microsoft.AspNetCore.Cors.dll",
            "Microsoft.AspNetCore.Cryptography.Internal.dll",
            "Microsoft.AspNetCore.DataProtection.Abstractions.dll",
            "Microsoft.AspNetCore.DataProtection.dll",
            "Microsoft.AspNetCore.Diagnostics.Abstractions.dll",
            "Microsoft.AspNetCore.Hosting.Abstractions.dll",
            "Microsoft.AspNetCore.Hosting.Server.Abstractions.dll",
            "Microsoft.AspNetCore.Html.Abstractions.dll",
            "Microsoft.AspNetCore.Http.Abstractions.dll",
            "Microsoft.AspNetCore.Http.dll",
            "Microsoft.AspNetCore.Http.Extensions.dll",
            "Microsoft.AspNetCore.Http.Features.dll",
            "Microsoft.AspNetCore.JsonPatch.dll",
            "Microsoft.AspNetCore.Localization.dll",
            "Microsoft.AspNetCore.Mvc.Abstractions.dll",
            "Microsoft.AspNetCore.Mvc.ApiExplorer.dll",
            "Microsoft.AspNetCore.Mvc.Core.dll",
            "Microsoft.AspNetCore.Mvc.Cors.dll",
            "Microsoft.AspNetCore.Mvc.DataAnnotations.dll",
            "Microsoft.AspNetCore.Mvc.dll",
            "Microsoft.AspNetCore.Mvc.Formatters.Json.dll",
            "Microsoft.AspNetCore.Mvc.Localization.dll",
            "Microsoft.AspNetCore.Mvc.Razor.dll",
            "Microsoft.AspNetCore.Mvc.Razor.Extensions.dll",
            "Microsoft.AspNetCore.Mvc.RazorPages.dll",
            "Microsoft.AspNetCore.Mvc.TagHelpers.dll",
            "Microsoft.AspNetCore.Mvc.ViewFeatures.dll",
            "Microsoft.AspNetCore.Razor.dll",
            "Microsoft.AspNetCore.Razor.Language.dll",
            "Microsoft.AspNetCore.Razor.Runtime.dll",
            "Microsoft.AspNetCore.ResponseCaching.Abstractions.dll",
            "Microsoft.AspNetCore.Routing.Abstractions.dll",
            "Microsoft.AspNetCore.Routing.dll",
            "Microsoft.AspNetCore.WebUtilities.dll",
            "Microsoft.CodeAnalysis.CSharp.dll",
            "Microsoft.CodeAnalysis.dll",
            "Microsoft.CodeAnalysis.Razor.dll",
            "Microsoft.CSharp.dll",
            "Microsoft.DotNet.PlatformAbstractions.dll",
            "Microsoft.Extensions.Caching.Abstractions.dll",
            "Microsoft.Extensions.Caching.Memory.dll",
            "Microsoft.Extensions.Configuration.Abstractions.dll",
            "Microsoft.Extensions.DependencyInjection.Abstractions.dll",
            "Microsoft.Extensions.DependencyInjection.dll",
            "Microsoft.Extensions.DependencyModel.dll",
            "Microsoft.Extensions.FileProviders.Abstractions.dll",
            "Microsoft.Extensions.FileProviders.Composite.dll",
            "Microsoft.Extensions.FileSystemGlobbing.dll",
            "Microsoft.Extensions.Hosting.Abstractions.dll",
            "Microsoft.Extensions.Localization.Abstractions.dll",
            "Microsoft.Extensions.Localization.dll",
            "Microsoft.Extensions.Logging.Abstractions.dll",
            "Microsoft.Extensions.ObjectPool.dll",
            "Microsoft.Extensions.Options.dll",
            "Microsoft.Extensions.Primitives.dll",
            "Microsoft.Extensions.WebEncoders.dll",
            "Microsoft.Net.Http.Headers.dll",
            "Microsoft.Win32.Registry.dll",
            "Newtonsoft.Json.Bson.dll",
            "Newtonsoft.Json.dll",
            "System.AppContext.dll",
            "System.Buffers.dll",
            "System.Collections.Concurrent.dll",
            "System.Collections.Immutable.dll",
            "System.ComponentModel.Annotations.dll",
            "System.Diagnostics.DiagnosticSource.dll",
            "System.Diagnostics.StackTrace.dll",
            "System.Dynamic.Runtime.dll",
            "System.IO.FileSystem.Primitives.dll",
            "System.Linq.dll",
            "System.Linq.Expressions.dll",
            "System.Memory.dll",
            "System.Numerics.Vectors.dll",
            "System.ObjectModel.dll",
            "System.Reflection.Emit.dll",
            "System.Reflection.Emit.ILGeneration.dll",
            "System.Reflection.Emit.Lightweight.dll",
            "System.Reflection.Metadata.dll",
            "System.Reflection.TypeExtensions.dll",
            "System.Runtime.CompilerServices.Unsafe.dll",
            "System.Runtime.Numerics.dll",
            "System.Security.AccessControl.dll",
            "System.Security.Cryptography.Cng.dll",
            "System.Security.Cryptography.OpenSsl.dll",
            "System.Security.Cryptography.Pkcs.dll",
            "System.Security.Cryptography.Primitives.dll",
            "System.Security.Cryptography.Xml.dll",
            "System.Security.Permissions.dll",
            "System.Security.Principal.Windows.dll",
            "System.Text.Encodings.Web.dll",
            "System.Text.RegularExpressions.dll",
            "System.Threading.dll",
            "System.Threading.Tasks.Extensions.dll",
            "System.Threading.Tasks.Parallel.dll",
            "System.Threading.Thread.dll",
            "System.ValueTuple.dll",
            "System.Xml.ReaderWriter.dll",
            "System.Xml.XDocument.dll",
            "System.Xml.XmlDocument.dll",
            "System.Xml.XPath.dll",
            "System.Xml.XPath.XDocument.dll",
        };

        private IEnumerable<string> _additionalFilesAfterPublishSelfContained = new[]
        {
            "System.Collections.dll",
            "System.Console.dll",
            "System.Diagnostics.Debug.dll",
            "System.Diagnostics.FileVersionInfo.dll",
            "System.Diagnostics.Tools.dll",
            "System.Diagnostics.Tracing.dll",
            "System.Globalization.Calendars.dll",
            "System.Globalization.dll",
            "System.IO.Compression.dll",
            "System.IO.dll",
            "System.IO.FileSystem.dll",
            "System.Reflection.dll",
            "System.Reflection.Extensions.dll",
            "System.Reflection.Primitives.dll",
            "System.Resources.ResourceManager.dll",
            "System.Runtime.dll",
            "System.Runtime.Extensions.dll",
            "System.Runtime.Handles.dll",
            "System.Runtime.InteropServices.dll",
            "System.Runtime.InteropServices.RuntimeInformation.dll",
            "System.Security.Cryptography.Algorithms.dll",
            "System.Security.Cryptography.Csp.dll",
            "System.Security.Cryptography.Encoding.dll",
            "System.Security.Cryptography.X509Certificates.dll",
            "System.Text.Encoding.CodePages.dll",
            "System.Text.Encoding.dll",
            "System.Text.Encoding.Extensions.dll",
            "System.Threading.Tasks.dll",
        };

        private IDictionary<RuntimeIdentifier, Func<IEnumerable<string>>> _additionalFilesAfterPublish =>
            new Dictionary<RuntimeIdentifier, Func<IEnumerable<string>>>()
            {
                { RuntimeIdentifier.None, () => 
                    _additionalFilesAfterPublishCommon
                    .Concat(new[]
                    {
                        Path.Combine("runtimes", "debian.8-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "fedora.23-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "fedora.24-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "opensuse.13.2-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "opensuse.42.1-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "osx", "lib", "netstandard1.6", "System.Security.Cryptography.Algorithms.dll"),
                        Path.Combine("runtimes", "osx.10.10-x64", "native", "System.Security.Cryptography.Native.Apple.dylib"),
                        Path.Combine("runtimes", "osx.10.10-x64", "native", "System.Security.Cryptography.Native.OpenSsl.dylib"),
                        Path.Combine("runtimes", "rhel.7-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "ubuntu.14.04-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "ubuntu.16.04-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "ubuntu.16.10-x64", "native", "System.Security.Cryptography.Native.OpenSsl.so"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.1", "System.Runtime.InteropServices.RuntimeInformation.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.3", "System.Diagnostics.FileVersionInfo.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.3", "System.IO.Compression.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.3", "System.Security.Cryptography.Csp.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.3", "System.Security.Cryptography.Encoding.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.3", "System.Text.Encoding.CodePages.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.6", "System.Security.Cryptography.Algorithms.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.6", "System.Security.Cryptography.OpenSsl.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard1.6", "System.Security.Cryptography.X509Certificates.dll"),
                        Path.Combine("runtimes", "unix", "lib", "netstandard2.0", "Microsoft.Win32.Registry.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.1", "System.Runtime.InteropServices.RuntimeInformation.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Diagnostics.FileVersionInfo.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.IO.Compression.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Security.AccessControl.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Security.Cryptography.Csp.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Security.Cryptography.Encoding.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Security.Principal.Windows.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.3", "System.Text.Encoding.CodePages.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.6", "System.Security.Cryptography.Algorithms.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.6", "System.Security.Cryptography.Cng.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard1.6", "System.Security.Cryptography.X509Certificates.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard2.0", "Microsoft.Win32.Registry.dll"),
                        Path.Combine("runtimes", "win", "lib", "netstandard2.0", "System.Security.Cryptography.Pkcs.dll"),
                    })
                },
                { RuntimeIdentifier.Win_x64, () => 
                    _additionalFilesAfterPublishCommon
                    .Concat(_additionalFilesAfterPublishSelfContained)
                    .Concat(new[]
                    {
                        "System.Threading.Overlapped.dll",
                    })
                },
                { RuntimeIdentifier.Linux_x64, () =>
                    _additionalFilesAfterPublishCommon
                    .Concat(_additionalFilesAfterPublishSelfContained)
                    .Concat(new[]
                    {
                        "System.Private.Uri.dll",
                    })
                },
            };

        public override IEnumerable<string> ExpectedFilesAfterPublish =>
            base.ExpectedFilesAfterPublish
            .Concat(RazorUtil.GetExpectedFilesAfterPublish(this))
            .Concat(_additionalFilesAfterPublish[RuntimeIdentifier]());
    }
}
