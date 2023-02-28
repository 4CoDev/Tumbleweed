using TumbleGD.Dictionaries;
using Tumbleweed.Delegates.Actions;
using Tumbleweed.Delegates.Actions.Nullary;

namespace TumbleGD.Nodes.Pools;

public interface INodePool
{
	IDictionary<object, INullaryAction> Graphicals { get; }
	
	IDictionary<object, INullaryAction> Physicals { get; }
	
	IDictionary<object, INullaryAction> Inputs { get; }
	
	IDictionary<object, object> Listenings { get; }
}