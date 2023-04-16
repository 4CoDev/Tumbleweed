using Tumbleweed.Nullability;

namespace Tumbleweed.Storages.Elements;

public sealed class ElementAsType<T> : IStorageElement<T> where T : notnull
{
	public ElementAsType(IStorageElement<Object> origin) =>
		this.origin = origin;
	
	public INullable<T> Nullable =>
		new NullableAsType<T>(origin.Nullable);

	public void Remove() =>
		origin.Remove();

	public void Place(T value) =>
		origin.Place(value);
	
	private readonly IStorageElement<Object> origin;
}