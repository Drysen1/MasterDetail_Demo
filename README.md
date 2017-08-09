# MasterDetail_Demo
This is a quick demo on how to use MasterDetailPage and how to change colour of Menu-burger on android. 

In Android Project:  Resources/Values/styles.xml add following lines: 
In MainTheme.Base:
'''XML
    <item name="drawerArrowStyle">@style/MainTheme.DrawerArrowStyle</item>
'''
As a separate style: 
'''XML
  <style name="MainTheme.DrawerArrowStyle" parent="Widget.AppCompat.DrawerArrowToggle">
    <item name="spinBars">true</item>
    <item name="color">#FF5722</item>
  </style>
  '''
