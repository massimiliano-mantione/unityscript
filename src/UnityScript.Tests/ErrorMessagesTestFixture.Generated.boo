
namespace UnityScript.Tests

import NUnit.Framework
	
partial class ErrorMessagesTestFixture:

	
	[Test] def array_instantiation_with_array_multiplication():
		RunTestCase("tests/error-messages/array-instantiation-with-array-multiplication.js")
		
	
	[Test] def array_struct_warning():
		RunTestCase("tests/error-messages/array-struct-warning.js")
		
	
	[Test] def array_type_name():
		RunTestCase("tests/error-messages/array-type-name.js")
		
	
	[Test] def builtins():
		RunTestCase("tests/error-messages/builtins.js")
		
	
	[Test] def cannot_convert_error():
		RunTestCase("tests/error-messages/cannot-convert-error.js")
		
	
	[Test] def double_array_in_float_array_var_initializer():
		RunTestCase("tests/error-messages/double-array-in-float-array-var-initializer.js")
		
	
	[Test] def error_for_final_used_as_identifier():
		RunTestCase("tests/error-messages/error-for-final-used-as-identifier.js")
		
	
	[Test] def for_variable_already_defined():
		RunTestCase("tests/error-messages/for-variable-already-defined.js")
		
	
	[Test] def function_type_name():
		RunTestCase("tests/error-messages/function-type-name.js")
		
	
	[Test] def generic_type_name():
		RunTestCase("tests/error-messages/generic-type-name.js")
		
	
	[Test] def implicit_main_shouldnt_be_redefined():
		RunTestCase("tests/error-messages/implicit-main-shouldnt-be-redefined.js")
		
	
	[Test] def incompatible_initializer_1():
		RunTestCase("tests/error-messages/incompatible-initializer-1.js")
		
	
	[Test] def inner_text():
		RunTestCase("tests/error-messages/inner_text.js")
		
	
	[Test] def interface_errors():
		RunTestCase("tests/error-messages/interface-errors.js")
		
	
	[Test] def invalid_attribute_sequence():
		RunTestCase("tests/error-messages/invalid-attribute-sequence.js")
		
	
	[Test] def invalid_generator_return_type():
		RunTestCase("tests/error-messages/invalid-generator-return-type.js")
		
	
	[Test] def iterator_warning():
		RunTestCase("tests/error-messages/iterator-warning.js")
		
	
	[Test] def missing_brace():
		RunTestCase("tests/error-messages/missing-brace.js")
		
	
	[Test] def nolinenumber():
		RunTestCase("tests/error-messages/nolinenumber.js")
		
	
	[Test] def obsolete_2():
		RunTestCase("tests/error-messages/obsolete-2.js")
		
	
	[Test] def obsolete():
		RunTestCase("tests/error-messages/obsolete.js")
		
	[Ignore("requires new parser infrastructure")]
	[Test] def overeager_semicolon():
		RunTestCase("tests/error-messages/overeager-semicolon.js")
		
	[Ignore("requires new parser infrastructure")]
	[Test] def overeager_semicolon2():
		RunTestCase("tests/error-messages/overeager-semicolon2.js")
		
	
	[Test] def rethrow_outside_catch():
		RunTestCase("tests/error-messages/rethrow-outside-catch.js")
		
	
	[Test] def semicolon_2():
		RunTestCase("tests/error-messages/semicolon-2.js")
		
	
	[Test] def semicolon():
		RunTestCase("tests/error-messages/semicolon.js")
		
	
	[Test] def static_instance_overload_resolution():
		RunTestCase("tests/error-messages/static-instance-overload-resolution.js")
		
	
	[Test] def strict_conditional_compilation():
		RunTestCase("tests/error-messages/strict-conditional-compilation.js")
		
	
	[Test] def strict_disallows_downcast():
		RunTestCase("tests/error-messages/strict-disallows-downcast.js")
		
	
	[Test] def strict_disallows_duck_downcast():
		RunTestCase("tests/error-messages/strict-disallows-duck-downcast.js")
		
	
	[Test] def strict_disallows_dynamic_dispatching():
		RunTestCase("tests/error-messages/strict-disallows-dynamic-dispatching.js")
		
	
	[Test] def strict_disallows_implicit_variable_declaration():
		RunTestCase("tests/error-messages/strict-disallows-implicit-variable-declaration.js")
		
	
	[Test] def strict_nongeneric_GetComponent():
		RunTestCase("tests/error-messages/strict-nongeneric-GetComponent.js")
		
	
	[Test] def unused_variable():
		RunTestCase("tests/error-messages/unused-variable.js")
		
	
	[Test] def virtual_warning():
		RunTestCase("tests/error-messages/virtual-warning.js")
		
	
	[Test] def void_declaration():
		RunTestCase("tests/error-messages/void-declaration.js")
		
	
	[Test] def void_in_hashtable():
		RunTestCase("tests/error-messages/void-in-hashtable.js")
		
	
	[Test] def voidcomparison():
		RunTestCase("tests/error-messages/voidcomparison.js")
		
	
	[Test] def yield_from_try_catch_finally():
		RunTestCase("tests/error-messages/yield-from-try-catch-finally.js")
		