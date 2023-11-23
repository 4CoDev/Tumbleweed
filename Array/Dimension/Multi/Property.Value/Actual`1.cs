using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Multi.Property.Value;

public sealed class Actual<T> : Any<T>
{
	public Actual(Property::Output.Any<Any<T>> property) =>
		this.property = property;

	public Property::Transput.Any<T> this
	[
		SCG::IEnumerable<Any> indices
	] =>
	(
		property.Value[indices]
	);

	public SCG::IEnumerable<Any> Size =>
		property.Value.Size;

	private readonly Property::Output.Any<Any<T>> property;
}