using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.From.System;

namespace Tumbleweed.Dictionary.Element;

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

	public Any<TElement> Nullability =>
		new One<TElement>(dictionary[key]);

	public void Remove() => dictionary.Remove(key);

	public void Place(TElement value) =>
		dictionary.Add(key, value);

	private readonly IDictionary<TKey, TElement> dictionary;
	
	private readonly TKey key;
}