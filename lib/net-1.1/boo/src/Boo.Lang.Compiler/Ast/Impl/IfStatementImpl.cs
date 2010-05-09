#region license
// Copyright (c) 2003, 2004, 2005 Rodrigo B. de Oliveira (rbo@acm.org)
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

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public  class IfStatementImpl : Statement
	{
		public IfStatementImpl()
		{
		}

		public IfStatementImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
		}
		protected Expression _condition;

		protected Block _trueBlock;

		protected Block _falseBlock;


		new public IfStatement CloneNode()
		{
			return Clone() as IfStatement;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.IfStatement;
			}
		}

		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnIfStatement((IfStatement)this);
		}

		override public bool Matches(Node node)
		{	
			IfStatement other = node as IfStatement;
			if (null == other) return false;
			if (!Node.Matches(_modifier, other._modifier)) return NoMatch("IfStatement._modifier");
			if (!Node.Matches(_condition, other._condition)) return NoMatch("IfStatement._condition");
			if (!Node.Matches(_trueBlock, other._trueBlock)) return NoMatch("IfStatement._trueBlock");
			if (!Node.Matches(_falseBlock, other._falseBlock)) return NoMatch("IfStatement._falseBlock");
			return true;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_modifier == existing)
			{
				this.Modifier = (StatementModifier)newNode;
				return true;
			}
			if (_condition == existing)
			{
				this.Condition = (Expression)newNode;
				return true;
			}
			if (_trueBlock == existing)
			{
				this.TrueBlock = (Block)newNode;
				return true;
			}
			if (_falseBlock == existing)
			{
				this.FalseBlock = (Block)newNode;
				return true;
			}
			return false;
		}

		override public object Clone()
		{
			IfStatement clone = (IfStatement)FormatterServices.GetUninitializedObject(typeof(IfStatement));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			if (null != _modifier)
			{
				clone._modifier = _modifier.Clone() as StatementModifier;
				clone._modifier.InitializeParent(clone);
			}
			if (null != _condition)
			{
				clone._condition = _condition.Clone() as Expression;
				clone._condition.InitializeParent(clone);
			}
			if (null != _trueBlock)
			{
				clone._trueBlock = _trueBlock.Clone() as Block;
				clone._trueBlock.InitializeParent(clone);
			}
			if (null != _falseBlock)
			{
				clone._falseBlock = _falseBlock.Clone() as Block;
				clone._falseBlock.InitializeParent(clone);
			}
			return clone;
		}

		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			if (null != _modifier)
			{
				_modifier.ClearTypeSystemBindings();
			}
			if (null != _condition)
			{
				_condition.ClearTypeSystemBindings();
			}
			if (null != _trueBlock)
			{
				_trueBlock.ClearTypeSystemBindings();
			}
			if (null != _falseBlock)
			{
				_falseBlock.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		public Expression Condition
		{
			get
			{

				return _condition;
			}

			set
			{
				if (_condition != value)
				{
					_condition = value;
					if (null != _condition)
					{
						_condition.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		public Block TrueBlock
		{
			get
			{

				return _trueBlock;
			}

			set
			{
				if (_trueBlock != value)
				{
					_trueBlock = value;
					if (null != _trueBlock)
					{
						_trueBlock.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		public Block FalseBlock
		{
			get
			{

				return _falseBlock;
			}

			set
			{
				if (_falseBlock != value)
				{
					_falseBlock = value;
					if (null != _falseBlock)
					{
						_falseBlock.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

