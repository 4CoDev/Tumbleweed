using Tumbleweed.Property.Option;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

public abstract class Envelope : Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public override Boolean Equals(System::Object? @object) =>
		batch.Equals(@object);

	public override Int32 GetHashCode() =>
		batch.GetHashCode();

	public override System::String? ToString() =>
		batch.ToString();

	public Tumbleweed.Array.Dimension.Multi.Any<Any<Any>> Subbatches =>
		batch.Subbatches;
	
	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	private readonly Any batch;
}