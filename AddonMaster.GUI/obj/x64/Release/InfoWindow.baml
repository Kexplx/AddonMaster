   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   AddonMaster.GUI    AddonMaster.GUI.InfoWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  -   
�������
�������$��1q�(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � WindowStyle$
 None=�   ShowCloseButton .   � 
ResizeMode$ NoResize=�   ShowMinButton .   � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterOwner=�   ShowTitleBar .  .��� $	��370��
�������$	��220��$��0,0,0,0q�.+�"  FontAwesome.WPF.ImageAwesome  -      Icon$ TimesCircle=�	 � ToolTip$	 Close��
 � Cursor$

 Hand��$��349,-5,5,187q�   
Foreground
 ����� J� RenderTransformOrigin$ 0.5,0.5&�  -   $ MinusCircle=�$	 Minimize��$

 Hand��$��328,-5,26,187q�
 �����$ 0.5,0.5&��� 
�������$��0,1,0,0q�$��0,27,0,0q��� -   $��txtMainWindow��|�.  $
 Arrow�� �� 
IsReadOnly . $y�	Collapsed=�$��0q�
���iii�$
��Left=�$����Use the blue button to install a new Addon.

The centric ListBox will display all your installed Addons.
Containing: Icon, Description (Mouseover Icon), Name, WoW Patch.

The Update Button (Blue Arrows in Addon Row) will reinstall it.

The Remove Button (Red Minus in Addon Row) will remove it.

The Report Button (Yellow Bug in left corner) opens the Bug Report Window.��$	��192��
�������$��0,28,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��370���� -    ��Name$ txtAddAddonWindow��|�.  $
 Arrow�� . $y�	Collapsed=�$��0q�
���iii�$
��Left=�$����1. Use the provided Link to select an Addon you want to install

2. The Link has to be in the format as shown in the placeholder box

3. Click the blue button to start the download

4. The Bar and the Spinner will show the download's progress 

4. After a completed Download the window will close automaticly��$	��192��
�������$��0,28,0,0q�$
 Wrap=�$	��Top=�$	��370���� -   $ txtReportWindow��|�.  $
 Arrow�� . $y�	Collapsed=�$��0q�
���iii�$
��Left=�$����1. Choose between a bug report or general feedback by checking either of the two Checkboxes over the textbox

2. Click into the TextBox in the middle and enter your message

3. The Blue Button in the right corner will be enabled once some text is entered

4. Clicking this button will send an Email to the support team and your Message will be processed.��$	��192��
�������$��0,28,0,0q�$
 Wrap=�$	��Top=�$	��370���� -   $ txtSetupWindow��|�.  $
 Arrow�� . $y�	Collapsed=�$��0q�
���iii�$
��Left=�$����1. Click on the yellow folder icon to choose your Addon Path

2. Usually this Path is C:\Program Files (x86)\World of Warcraft\Interface\AddOns

3. Clicking on the blue Button in the right corner will create the AddonMaster Setup Folder in the selected Path. 

4. Do not Move/Edit/Remove this Folder or else the Program won't work properly��$	��192��
�������$��0,28,0,0q�$
 Wrap=�$	��Top=�$	��370���� $��Addon Master��
���iii�$
��Bold"�$
��Left=�$	��Top=�$��0,4,0,0q�$��23��