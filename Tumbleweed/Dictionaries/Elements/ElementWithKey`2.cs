using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;

namespace Tumbleweed.Dictionaries.Elements;

public sealed class ElementWithKey<TKey, TElement> :
	IDictionaryElement<TElement>
	where TElement : notnull
{
	public ElementWithKey
	(
		IDictionary<TKey, TElement> dictionary,
		TKey key
	)
	{
		this.dictionary = dictionary;
		this.key = key;
	}

	public INullable<TElement> Nullability =>
		new NullableFromSystem<TElement>(dictionary[key]);

	public void Remove() => dictionary.Remove(key);

	public void Place(TElement value) =>
		dictionary.Add(key, value);

	private readonly IDictionary<TKey, TElement> dictionary;
	
	private readonly TKey key;
}