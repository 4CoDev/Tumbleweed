using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Item.Every.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;
using System = System;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Number.Integer.System.Medium.From.Bytes;

public sealed class System : global::Tumbleweed.Scalar.Immutable.Envelope<System::Int32>
{
	public System(IEnumerable<Any<System::Byte>> bytes) : this
	(
		new Value<System::Byte>(bytes)
	)
	{
	}
	
	public System(IEnumerable<System::Byte> bytes) : this
	(
		new ReadOnlySpan::From.Enumerable<System::Byte>(bytes)
	)
	{
	}
	
	public System(ReadOnlySpan::Any<System::Byte> bytes) : base
	(
		new Actual<Int32>(
			() => Function((bytes)))
	)
	{
	}

	private static Int32 Function(ReadOnlySpan::Any<System::Byte> bytes) =>
	(
		BitConverter.ToInt32(
			new ReadOnlySpan::With.Size.Statement<System::Byte>(bytes, 4).Value)
	);
}