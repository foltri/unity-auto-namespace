# unity-auto-namespace
Editor script that adds project name as namespace to script template. This way namespace is automatically added in newly created scripts.

1. Download unity-auto-namespace.unitypackage from the latest [release](https://github.com/foltri/unity-auto-namespace/releases) and import it to your project.

2. Find `81-C# Script-NewBehaviourScript.cs.txt`. Change the version number in the path if needed.
    * On Windows in: `c:\Program Files\Unity\Editor\Data\Resources\ScriptTemplates\`
    * On Mac in: `/Applications/Unity/Unity.app/Contents/Resources/ScriptTemplates/`
    * On Linux in: `~/Unity/Hub/Editor/2019.4.13f1/Editor/Data/Resources/ScriptTemplates/`
    
3. Replace its content with the following: 

```C#
using UnityEngine;

namespace #PROJECTNAME#
{

    public class #SCRIPTNAME# : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
```

The solution is based on: https://stackoverflow.com/a/58975868/5980156
