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
		Mathematics.Geometry.Stereometry.Graphical.Mesh.Any mesh, 
		Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any size
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

	public Mathematics.Geometry.Stereometry.Graphical.Mesh.Any Mesh { get; }

	public Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any Aabb { get; }
}