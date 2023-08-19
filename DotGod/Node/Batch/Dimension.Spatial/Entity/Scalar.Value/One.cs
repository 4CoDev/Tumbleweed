using DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Scalar.Value;

public sealed class One : Any
{
	public One(Any<Any> any) =>
		this.any = any;
	
	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public Tumbleweed.Scalar.Nullable.Any<Godot.Node> Node =>
		any.Value.Node;

	public Geometry.Spatial.Concave.Graphical.Mesh.Any Mesh =>
		any.Value.Mesh;

	public Tumbleweed.Geometry.Spatial.Aabb.Any Aabb =>
		any.Value.Aabb;

	private readonly Any<Any> any;
}