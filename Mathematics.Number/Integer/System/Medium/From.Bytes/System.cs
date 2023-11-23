using Property = Tumbleweed.Property.Output;
using Tumbleweed.Enumerable.Item.Every.Property;
using Tumbleweed.Memory.Span.ReadOnly.Requirement.Length;
using Tumbleweed.Property.Output.Function.Result;
using System = System;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Bytes;

public sealed class System : global::Tumbleweed.Property.Output.Envelope<System::Int32>
{
	public System(IEnumerable<Property::Any<System::Byte>> bytes) : this
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
			new System<System::Byte>(bytes, 4).Value)
	);
}