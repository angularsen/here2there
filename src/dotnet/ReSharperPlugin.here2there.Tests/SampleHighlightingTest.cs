﻿using JetBrains.Application.Settings;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.FeaturesTestFramework.Daemon;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace ReSharperPlugin.here2there.Tests
{
  public class SampleHighlightingTest : CSharpHighlightingTestBase
  {
    protected override string RelativeTestDataPath => "CSharp";

    protected override bool HighlightingPredicate(
      IHighlighting highlighting,
      IPsiSourceFile sourceFile,
      IContextBoundSettingsStore settingsStore)
    {
      return highlighting is SampleHighlighting;
    }

    [Test] public void TestSampleTest() { DoNamedTest2(); }
  }
}