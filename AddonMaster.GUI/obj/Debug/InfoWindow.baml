   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI    AddonMaster.GUI.InfoWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   -   5        
�������
�������$��1q�5      (   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � WindowStyle$
 None=�5   3      ShowCloseButton .   � 
ResizeMode$ NoResize=�5   /      ShowMinButton .   � SizeToContent$ WidthAndHeight=�5       � WindowStartupLocation$ CenterOwner=�66      ShowTitleBar .  .��5      � $	��370��6   
�������$	��220��6*   $��0,0,0,0q�67   .+�5   
   "  FontAwesome.WPF.ImageAwesome  -   5           Icon$ TimesCircle=�5      	 � ToolTip$	 Close��6-   
 � Cursor$

 Hand��6=   $��349,-5,5,187q�6n      
Foreground
 ����� J� RenderTransformOrigin$ 0.5,0.5&�6�     5   
   -   5        $ MinusCircle=�5      $	 Minimize��6-   $

 Hand��6@   $��328,-5,26,187q�6q   
 �����$ 0.5,0.5&�6�   �� 5   
   
�������$��0,1,0,0q�6$   $��0,27,0,0q�6>   5      �� 5   
   -   5        $��txtMainWindow��5   >  |�.  $
 Arrow��6$    �� 
IsReadOnly . $y�	Collapsed=�6E   $��0q�6\   
���iii�$
��Left=�6�   $����Use the blue button to install a new Addon.

The centric ListBox will display all your installed Addons.
Containing: Icon, Description (Mouseover Icon), Name, WoW Patch.

The Update Button (Blue Arrows in Addon Row) will reinstall it.

The Remove Button (Red Minus in Addon Row) will remove it.

The Report Button (Yellow Bug in left corner) opens the Bug Report Window.��6�   $	��192��6S  
�������$��0,28,0,0q�6s   �� TextWrapping$
 Wrap=�6�  $	��Top=�6�  $	��370��6�  �� 5   
   -   5         ��Name$ txtAddAddonWindow��5     |�.  $
 Arrow��6$    . $y�	Collapsed=�6E   $��0q�6\   
���iii�$
��Left=�6�   $����1. Use the provided Link to select an Addon you want to install

2. The Link has to be in the format as shown in the placeholder box

3. Click the blue button to start the download

4. The Bar and the Spinner will show the download's progress 

4. After a completed Download the window will close automaticly��6�   $	��192��60  
�������$��0,28,0,0q�6Q  $
 Wrap=�6c  $	��Top=�6w  $	��370��6�  �� 5   
   -   5        $ txtReportWindow��5   @  |�.  $
 Arrow��6$    . $y�	Collapsed=�6E   $��0q�6\   
���iii�$
��Left=�6�   $����1. Choose between a bug report or general feedback by checking either of the two Checkboxes over the textbox

2. Click into the TextBox in the middle and enter your message

3. The Blue Button in the right corner will be enabled once some text is entered

4. Clicking this button will send an Email to the support team and your Message will be processed.��6�   $	��192��6Y  
�������$��0,28,0,0q�6y  $
 Wrap=�6�  $	��Top=�6�  $	��370��6�  �� 5   
   -   5        $ txtSetupWindow��5   1  |�.  $
 Arrow��6$    . $y�	Collapsed=�6E   $��0q�6\   
���iii�$
��Left=�6�   $����1. Click on the yellow folder icon to choose your Addon Path

2. Usually this Path is C:\Program Files (x86)\World of Warcraft\Interface\AddOns

3. Clicking on the blue Button in the right corner will create the AddonMaster Setup Folder in the selected Path. 

4. Do not Move/Edit/Remove this Folder or else the Program won't work properly��6�   $	��192��6I  
�������$��0,28,0,0q�6i  $
 Wrap=�6{  $	��Top=�6�  $	��370��6�  �� 5   
   $��Addon Master��6   
���iii�$
��Bold"�6<   $
��Left=�6N   $	��Top=�6i   $��0,4,0,0q�6�   $��23��6�   5      5      