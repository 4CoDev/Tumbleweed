using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Property.Output;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Natural.Property;

public sealed class Value : Any
{
	public Value(Any<Any> property) =>
		this.property = property;

	public IEnumerable<Boolean.Any> Bits =>
		property.Value.Bits;

	private readonly Any<Any> property;
}