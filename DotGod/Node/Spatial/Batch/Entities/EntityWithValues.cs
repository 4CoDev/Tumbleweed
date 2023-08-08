using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using DotGod.Node.Spatial.Batch.Entities.Equality;
using DotGod.Node.Spatial.Batch.Space;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Node.Spatial.Batch.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues
	(
		Any<Godot.Node> node,
		Geometry.Spatial.Concave.Graphical.Mesh.Any mesh, 
		ISpace size
	)
	{
		Node = node;
		Mesh = mesh;
		Occupation = size;
	}

	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public Any<Godot.Node> Node { get; }

	public Geometry.Spatial.Concave.Graphical.Mesh.Any Mesh { get; }

	public ISpace Occupation { get; }
}