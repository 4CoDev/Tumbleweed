using Scalar = Tumbleweed.Scalar;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class One : Scalar::Nullable.Envelope<String::Any>
{
	public One(System::String? nullable) : this
	(
		new Scalar::Nullable.From.System.One
			<System::String>
			(nullable)
	)
	{
	}
	
	public One
	(
		Scalar::Immutable.Any<System::String?> nullable
	) : this
	(
		 new Scalar::Nullable.From.System.One
			 <System::String>
			 (nullable)
	)
	{
	}
	
	public One
	(
		Scalar::Nullable.Any<System::String> nullables
	) : base
	(
		new Scalar::Nullable.With.Members<String::Any>(
			new NonNullable.One(nullables),
			new Tumbleweed.Scalar.Nullable.Has.Value(nullables))
	)
	{
	}
}