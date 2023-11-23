using Enumerable = Tumbleweed.Enumerable;
using String = Tumbleweed.String;
using System = System;
using Nullable = Tumbleweed.Property.Nullable;

namespace Tumbleweed.String.Operation.Spare.When.Null;

public sealed class Multiple : Enumerable::Envelope<String::Any>
{
	public Multiple
	(
		IEnumerable<System::String?> nullables,
		System::String spare
	) : this
	(
		new From.System.Nullable.Multiple(nullables),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<String::Any?> nullables,
		String::Any spare
	) : this
	(
		new Nullable::From.System.Multiple<String::Any>(nullables),
		spare
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Nullable::Any<String::Any>> nullables,
		String::Any spare
	) : base
	(
		new Enumerable::Selected
			<Nullable::Any<String::Any>, String::Any>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}

	private static Any Expression
	(
		Nullable::Any<String::Any> nullable,
		String::Any spare
	) =>
	(
		new One(nullable, spare)
	);
}