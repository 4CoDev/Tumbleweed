using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;
using System = System;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class System : Envelope<System::Single>
{
	public System(IEnumerable<System::Byte> bytes) : this
	(
		new ReadOnlySpan::From.Enumerable<System::Byte>(bytes)
	)
	{
	}
	
	public System(ReadOnlySpan::Any<System::Byte> bytes) : base
	(
		new Actual<System::Single>(
			() => Function(bytes))
	)
	{
	}
	
	private static System::Single Function
	(
		ReadOnlySpan::Any<System::Byte> bytes
	) =>
	(
		BitConverter.ToSingle(
			new ReadOnlySpan::With.Size.Statement<System::Byte>(bytes, 4).Value)
	);
}