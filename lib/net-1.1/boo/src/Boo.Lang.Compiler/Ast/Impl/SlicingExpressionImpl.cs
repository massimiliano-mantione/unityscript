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
	public  class SlicingExpressionImpl : Expression
	{
		public SlicingExpressionImpl()
		{
		}

		public SlicingExpressionImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
		}
		protected Expression _target;

		protected SliceCollection _indices;


		new public SlicingExpression CloneNode()
		{
			return Clone() as SlicingExpression;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.SlicingExpression;
			}
		}

		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnSlicingExpression((SlicingExpression)this);
		}

		override public bool Matches(Node node)
		{	
			SlicingExpression other = node as SlicingExpression;
			if (null == other) return false;
			if (!Node.Matches(_target, other._target)) return NoMatch("SlicingExpression._target");
			if (!Node.AllMatch(_indices, other._indices)) return NoMatch("SlicingExpression._indices");
			return true;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_target == existing)
			{
				this.Target = (Expression)newNode;
				return true;
			}
			if (_indices != null)
			{
				Slice item = existing as Slice;
				if (null != item)
				{
					Slice newItem = (Slice)newNode;
					if (_indices.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			return false;
		}

		override public object Clone()
		{
			SlicingExpression clone = (SlicingExpression)FormatterServices.GetUninitializedObject(typeof(SlicingExpression));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._expressionType = _expressionType;
			if (null != _target)
			{
				clone._target = _target.Clone() as Expression;
				clone._target.InitializeParent(clone);
			}
			if (null != _indices)
			{
				clone._indices = _indices.Clone() as SliceCollection;
				clone._indices.InitializeParent(clone);
			}
			return clone;
		}

		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_expressionType = null;
			if (null != _target)
			{
				_target.ClearTypeSystemBindings();
			}
			if (null != _indices)
			{
				_indices.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		public Expression Target
		{
			get
			{

				return _target;
			}

			set
			{
				if (_target != value)
				{
					_target = value;
					if (null != _target)
					{
						_target.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		public SliceCollection Indices
		{
			get
			{

			if (_indices == null) _indices = new SliceCollection(this);

				return _indices;
			}

			set
			{
				if (_indices != value)
				{
					_indices = value;
					if (null != _indices)
					{
						_indices.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

