using Tumbleweed.Nullables;

namespace Tumbleweed.Storages.Elements;

public abstract class ElementEnvelope<T> : IStorageElement<T> where T : notnull
{
	protected ElementEnvelope(IStorageElement<T> element) =>
		this.element = element;

	public override Boolean Equals(Object? @object) =>
		element.Equals(@object);

	public override Int32 GetHashCode() =>
		element.GetHashCode();

	public override String? ToString() =>
		element.ToString();

	public INullable<T> Nullable => element.Nullable;

	public void Remove() => element.Remove();

	public void Place(T value) => element.Place(value);
	
	private readonly IStorageElement<T> element;
}