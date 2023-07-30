using DotGod.Spatial._Node.Batch.Entities.Equality;
using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class EntityOfScalar : ISpatialEntity
{
	public EntityOfScalar(Any<ISpatialEntity> any) =>
		this.any = any;
	
	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public Tumbleweed.Scalar.Nullable.Any<Godot.Node> Node =>
		any.Value.Node;

	public IMesh Mesh =>
		any.Value.Mesh;

	public ISpace Occupation =>
		any.Value.Occupation;

	private readonly Any<ISpatialEntity> any;
}