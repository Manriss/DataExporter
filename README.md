# DataExporter
Beta Version (Navisworks 2019)

Installation:

1-Copy folder DATAEXPORTER.MGD to "C:\Program Files\Autodesk\Navisworks Manage 2019\Plugins"

2-Copy the content of the folder Dependencies to "C:\Program Files\Autodesk\Navisworks Manage 2019\Dependencies"

3-Run Navisworks

4-Go to View/Windows and activate the plugin.

How it works:

1-Select up to 5 elements and then click "select properties", then, select the properties that will be exported later.

2-Select the elements to be exported (Will export only the properties you selected before), click "Get properties from selected elements"

3-Filter by properties or hide columns if needed (very basic filter: property contais txtValue1 OR txtValue2 OR...)

4-Export to CSV

POINT 2 IS CRITICAL, what you select is what you get...
Many other filters can be implemented, even an excel like filter, (http://objectlistview.sourceforge.net/cs/filtering.html#column-filtering-label), but as documentation explains:
"Filtering and TreeListViews interact in a predictable but perhaps unexpected fashion.
Filtering considers only rows that are currently exposed (that is, all their ancestorss are expanded)."
because of that is is not activated.


I am not a professional programmer, I am self-taught and a BIM enthusiast.
Use the plugin at your own risk
