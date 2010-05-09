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
	public  class ArrayLiteralExpressionImpl : ListLiteralExpression
	{
		public ArrayLiteralExpressionImpl()
		{
		}

		public ArrayLiteralExpressionImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
		}
		protected ArrayTypeReference _type;


		new public ArrayLiteralExpression CloneNode()
		{
			return Clone() as ArrayLiteralExpression;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.ArrayLiteralExpression;
			}
		}

		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnArrayLiteralExpression((ArrayLiteralExpression)this);
		}

		override public bool Matches(Node node)
		{	
			ArrayLiteralExpression other = node as ArrayLiteralExpression;
			if (null == other) return false;
			if (!Node.AllMatch(_items, other._items)) return NoMatch("ArrayLiteralExpression._items");
			if (!Node.Matches(_type, other._type)) return NoMatch("ArrayLiteralExpression._type");
			return true;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_items != null)
			{
				Expression item = existing as Expression;
				if (null != item)
				{
					Expression newItem = (Expression)newNode;
					if (_items.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_type == existing)
			{
				this.Type = (ArrayTypeReference)newNode;
				return true;
			}
			return false;
		}

		override public object Clone()
		{
			ArrayLiteralExpression clone = (ArrayLiteralExpression)FormatterServices.GetUninitializedObject(typeof(ArrayLiteralExpression));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._expressionType = _expressionType;
			if (null != _items)
			{
				clone._items = _items.Clone() as ExpressionCollection;
				clone._items.InitializeParent(clone);
			}
			if (null != _type)
			{
				clone._type = _type.Clone() as ArrayTypeReference;
				clone._type.InitializeParent(clone);
			}
			return clone;
		}

		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_expressionType = null;
			if (null != _items)
			{
				_items.ClearTypeSystemBindings();
			}
			if (null != _type)
			{
				_type.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		public ArrayTypeReference Type
		{
			get
			{

				return _type;
			}

			set
			{
				if (_type != value)
				{
					_type = value;
					if (null != _type)
					{
						_type.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

