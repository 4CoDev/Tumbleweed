namespace DotGod.Node.Spatial.Batch.Entities;

public sealed class ObjectAsEntity : EntityEnvelope
{
	public ObjectAsEntity(Object @object) : base
	(
		new EntityOfScalar(
			new Tumbleweed.Object.Unpacked<ISpatialEntity>(@object))
	)
	{
	}
}