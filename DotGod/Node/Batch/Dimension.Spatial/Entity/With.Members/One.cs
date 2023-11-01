using DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Property.Nullable;
using Mesh = DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.With.Members;

public sealed class One : Any
{
	public One
	(
		Any<Godot.Node> node,
		Mesh::Any mesh, 
		Aabb::Any aabb
	)
	{
		Node = node;
		Mesh = mesh;
		Aabb = aabb;
	}

	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).AsSystem;

	public Any<Godot.Node> Node { get; }

	public Mesh::Any Mesh { get; }

	public Aabb::Any Aabb { get; }
}