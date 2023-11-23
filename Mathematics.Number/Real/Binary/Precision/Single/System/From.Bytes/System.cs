using Tumbleweed.Memory.Span.ReadOnly;
using Property = Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;
using System = System;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class System : Property::Envelope<System::Single>
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
			new ReadOnlySpan::Requirement.Length.System
				<System::Byte>
				(bytes, 4).Value)
	);
}