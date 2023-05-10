using DotGod.Geometry.Graphical.Meshes;
using DotGod.Nodes.BatchMaps.Spatial.Entities.Equality;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Godot;
using Tumbleweed.Nullables;
using Tumbleweed.Objects.Hashes;
using Tumbleweed.Objects.Strings;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities;

public sealed class EntityOfScalar : ISpatialEntity
{
	public EntityOfScalar(IScalar<ISpatialEntity> scalar) =>
		this.scalar = scalar;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public INullable<Node> Node =>
		scalar.Value.Node;

	public IMesh Mesh =>
		scalar.Value.Mesh;

	public ISpace Occupation =>
		scalar.Value.Occupation;

	private readonly IScalar<ISpatialEntity> scalar;
}