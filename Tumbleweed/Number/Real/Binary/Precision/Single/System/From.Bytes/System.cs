using Scalar = Tumbleweed.Scalar;
using System = System;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class System : Scalar::Envelope<System::Single>
{
	public System(IEnumerable<System::Byte> bytes) : this
	(
		new ReadOnlySpan::From.Enumerable<System::Byte>(bytes)
	)
	{
	}
	
	public System(ReadOnlySpan::Any<System::Byte> bytes) : base
	(
		new Scalar::Function.Result<System::Single>(
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