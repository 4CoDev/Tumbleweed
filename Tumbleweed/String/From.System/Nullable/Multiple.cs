using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class Multiple : 
	Enumerable::Envelope<
		Scalar::Nullable.Any<
			String::Any>>
{
	public Multiple
	(
		IEnumerable<System::String?> nullables
	) : this
	(
		new Scalar::Nullable.From.System.Multiple
			<System::String>
			(nullables)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Scalar::Nullable.Any<System::String>> nullables
	) : base
	(
		new Enumerable::Selected
		<
			Scalar::Nullable.Any<System::String>,
			Scalar::Nullable.Any<String::Any>
		>
		(
			nullables,
			nullable => new String::From.System.Nullable.One(nullable)
		)
	)
	{
	}
}