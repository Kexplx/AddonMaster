   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   AddonMaster.GUI!   AddonMaster.GUI.SetupWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  -   
�������$��1q�(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � 
ResizeMode$ NoResize=�
������� � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�   ShowTitleBar .     ShowCloseButton .     ShowMinButton .  .��� $	��150��$	��370��
�������.+��� $��1q�
�������$��
30,59,5,67q�._��� -   $��TxtAddonFolderPath��
���   � �� 
IsReadOnly . $��Center=�$	��335��
�������$��0q�$��Center=�$
��Left=�$��0q�$��24������ *OutlinePlain+	 �� Mode$	 TwoWay=�
 �� NotifyOnTargetUpdated
 . ��  J� IsHitTestVisible .  $?��9C:\Program Files (x86)\World of Warcraft\Interface\AddOns��$��Center=�$
��Left=�$��
34,63,0,71q�
�������$	��331������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ TxtAddonFolderPath�� �� Value  .a���  � y�$ Visible=�"  FontAwesome.WPF.ImageAwesome  -   $��BtnOpenDirectoryDialogue�� � Cursor$
 Hand�� J� Opacity$	 0.8Q�   Icon$ 
FolderOpen=�   
Foreground
 ���F�$��3,59,343,67q� J� RenderTransformOrigin$ 0.5,0&�  -     Name$ BtnContinue��{�.  $
 Hand��
 ���F�$	 0.6Q�$ SignIn=�$��341,126,6,5q�$ 0.5,0&��� -   $��	LblStatus��$��Please select valid path��$y�	Collapsed=�
���\\��$
��Left=�$��200,123,0,0q�$	��Top=�$	��146��  -   $ TimesCircle=� � ToolTip$ Close��$
 Hand��$��345,5,5,125q�
 �����$ 0.5,0.5&�  -   $ MinusCircle=�$ Minimize��$
 Hand��$��320,5,30,125q�
 �����$ 0.5,0.5&�  -   $ QuestionCircle=�$
 Help��$
 Hand��$��295,5,55,125q�
 �����$ 0.5,0.5&��� 
���iii�$+��%Select World of Warcraft addon folder��$
��Left=�$��	28,36,0,0q�$	��Top=�$	��228��$��23���� $��
0,29,0,119q�
�������$��0,1,0,0q��� $��Addon Master��
���iii�$
��Bold"�$
��Left=�$��0,5,0,0q�$	��Top=�