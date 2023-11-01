using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Property = Tumbleweed.Property.Output;

using Real = Tumbleweed.Mathematics.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Property;

public sealed class Value : Any
{
	public Value(Property::Any<Any> vertex) =>
		this.vertex = vertex;

	public Any<Real::Any> Translation =>
		vertex.Value.Translation;

	private readonly Property::Any<Any> vertex;
}