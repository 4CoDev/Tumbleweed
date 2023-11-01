using DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Property.Output;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Property.Value;

public sealed class One : Any
{
	public One(Any<Any> any) =>
		this.any = any;
	
	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).AsSystem;

	public Tumbleweed.Property.Nullable.Any<Godot.Node> Node =>
		any.Value.Node;

	public Mathematics.Geometry.Stereometry.Graphical.Mesh.Any Mesh =>
		any.Value.Mesh;

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb =>
		any.Value.Aabb;

	private readonly Any<Any> any;
}