using Tumbleweed.Enumerable;
using Tumbleweed.String;
using Tumbleweed.String.Empty.When.Null;

namespace Tumbleweed.Object.String;

public sealed class StringsFromObjects : Envelope<Any>
{
	public StringsFromObjects(params System.Object[] objects) : this
	(
		new Concatenated<System.Object>(objects)
	)
	{
	}
	
	public StringsFromObjects(IEnumerable<System.Object> objects) : base
	(
		new Selected<System.Object, Any>(
			objects,
			@object => new One(
				new StringFromObject(@object)))
	)
	{
	}
}