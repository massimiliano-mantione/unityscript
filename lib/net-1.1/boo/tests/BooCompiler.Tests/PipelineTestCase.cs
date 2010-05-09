#region license
// Copyright (c) 2004, Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

using Boo.Lang;

namespace BooCompiler.Tests
{
	using System;
	using NUnit.Framework;
	using Boo.Lang.Compiler;

	public class DummyStep : ICompilerStep
	{		
		int _runCount = 0;
		
		public void Initialize(CompilerContext context)
		{			
		}

		public void Run()
		{
			++_runCount;
		}
		
		public void Dispose()
		{			
		}

		public int RunCount
		{
			get
			{
				return _runCount;
			}
		}
	}

	public class DummyStep2 : DummyStep
	{
	}
	
	public class DummyStep3 : DummyStep
	{
	}
	
	public class DummyStep4 : DummyStep
	{
	}

	public class ActionStep : ICompilerStep
	{
		private readonly Action _action;
		private CompilerContext _context;

		public ActionStep(Action action)
		{
			_action = action;
		}

		#region ICompilerStep Members

		public void Run()
		{
			_action(_context);
		}

		#endregion

		#region ICompilerComponent Members

		public void Initialize(CompilerContext context)
		{
			_context = context;
		}

		#endregion

		#region IDisposable Members

		public void Dispose()
		{
			_context = null;
		}

		#endregion
	}

	/// <summary>	
	/// </summary>
	[TestFixture]
	public class PipelineTestCase
	{	
		CompilerPipeline _pipeline;

		[SetUp]
		public void SetUp()
		{
			_pipeline = new CompilerPipeline();			
		}

		public readonly List calls = new List();

		[Test]
		public void TestEventSequence()
		{
			_pipeline.Before +=new CompilerPipelineEventHandler(_pipeline_Before);
			_pipeline.BeforeStep +=new CompilerStepEventHandler(_pipeline_BeforeStep);
			_pipeline.Add(new ActionStep(new Action(_pipeline_Action)));
			_pipeline.AfterStep += new CompilerStepEventHandler(_pipeline_AfterStep);
			_pipeline.After += new CompilerPipelineEventHandler(_pipeline_After);
			_pipeline.Run(new CompilerContext());
			Assert.AreEqual(
				new List(new string[] {"before", "before step", "step", "after step", "after"}),
				calls);
		}

		private void _pipeline_Action(object o)
		{
			calls.Add("step");
		}

		[Test]
		public void TestConstructor()
		{
			Assert.AreEqual(0, _pipeline.Count);
		}

		[Test]
		public void TestAdd()
		{
			DummyStep p = new DummyStep();			
			_pipeline.Add(p);
			Assert.AreEqual(1, _pipeline.Count);
		}

		[Test]
		public void TestRun()
		{
			DummyStep p1 = new DummyStep();		
			DummyStep p2 = new DummyStep();

			_pipeline.Add(p1);
			_pipeline.Add(p2);

			Assert.AreEqual(0, p1.RunCount);
			Assert.AreEqual(0, p2.RunCount);
			_pipeline.Run(new CompilerContext(new CompilerParameters(), new Boo.Lang.Compiler.Ast.CompileUnit()));
			Assert.AreEqual(1, p1.RunCount);
			Assert.AreEqual(1, p2.RunCount);
		}
		
		void AssertPipeline(params ICompilerStep[] expected)
		{
			Assert.AreEqual(expected.Length, _pipeline.Count);
			for (int i=0; i<expected.Length; ++i)
			{
				Assert.AreSame(expected[i], _pipeline[i]);
			}
		}

		private void _pipeline_Before(object sender, CompilerPipelineEventArgs args)
		{
			calls.Add("before");
		}

		private void _pipeline_BeforeStep(object sender, CompilerStepEventArgs args)
		{
			calls.Add("before step");
		}

		private void _pipeline_AfterStep(object sender, CompilerStepEventArgs args)
		{
			calls.Add("after step");
		}

		private void _pipeline_After(object sender, CompilerPipelineEventArgs args)
		{
			calls.Add("after");
		}
	}
}
