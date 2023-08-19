using DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.With.Members;

public sealed class One : Any
{
	public One
	(
		Any<Godot.Node> node,
		Geometry.Spatial.Concave.Graphical.Mesh.Any mesh, 
		Tumbleweed.Geometry.Spatial.Aabb.Any size
	)
	{
		Node = node;
		Mesh = mesh;
		Aabb = size;
	}

	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public Any<Godot.Node> Node { get; }

	public Geometry.Spatial.Concave.Graphical.Mesh.Any Mesh { get; }

	public Tumbleweed.Geometry.Spatial.Aabb.Any Aabb { get; }
}