   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   AddonMaster.GUI    AddonMaster.GUI.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  -   
�������$��1q�
�������(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � 
ResizeMode$ CanMinimize=�   ShowMinButton .     ShowCloseButton .   � SizeToContent$ WidthAndHeight=�   ShowTitleBar .     ShowMaxRestoreButton .   � WindowStartupLocation$ CenterScreen=� � 	Resources  !  ListBoxtemStyleNoHighlighting	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name��%`   &	        �� "	 ��.��� 
 � �� �� " ��.R�� #��z��.+��� $ contentPresenter��.��� $	��700��$	��400��
������� � RowDefinitions �� $	��27* ��� .+��� 
�������$
��Left=�$��	0,665,0,0q�$	��Top=�$��35��$	��400��$��2���� -    ��Name$ LblAddonList��$��0��#��[  $��Stretch=�$��	0,34,0,10q�
�������$��0,1,0,1q�
������ ���� .R��� 
�������$��2,3,2,0q�$��1q�._�� $��0q�
������� � ColumnDefinitions �� $��30 ��� $��10 ��� $��* ��� $��60 ��� $��30 ��� $��30 ��� $��30 �.+��� -   $��30��$��0������ *Image+ � ToolTip �� *Description+�� $��1���� -   $	��Top=�
���   �$��2������ *
Addon.Name+ �� *Addon.Description+�� -   $��Bottom=�
�������$��11(�$��2������ *Addon.Patch+"  FontAwesome.WPF.ImageAwesome     Icon$	 Cog=� J� Opacity$	 0.8Q�   
Foreground
 �iii�$��4��   Spin . $��22��   SpinDuration$ 2Q�$��2��y��� *UpdateCogVisibility+    Name$ 	imgUpdate��-   $ Refresh=�$ Update addon��$��5�� � Cursor$
 Hand��
 ���F�$��22��  $ 	imgRemove��-   $ MinusCircle=�$ Remove addon��$��6��
 �\\��$
 Hand��$��24��  -   $ ImgAdd��$ 
PlusCircle=�$ Install an addon��$
 Hand��$��364,669,5,3q�
 ���F�$��0��$��2���� -	    ��Name$ LblEmptyList��$��0��$��Center=�$-��'Use the blue button to install an addon��
�������$��20(�$��11,290,10,237q�  -
   $	 Bug=�$# Report a bug or give feedback��$
 Hand��$��5,670,371,2q�
 �����$��0��$��2��  -   $��0��$ TimesCircle=�$ Close��$ 1Q�$
 Hand��$��371,5,5,646q�
 �����  -   $��0��$ MinusCircle=�$ Minimize��$ 1Q�$
 Hand��$��341,5,35,646q�
 ����� J� RenderTransformOrigin$ 	1.66,0.85&�  -   $��0��$ QuestionCircle=�$
 Help��$ 1Q�$
 Hand��$��312,5,64,646q�
 ������� $��0��$��Addon Master��
���iii�$
��Bold"�$
��Left=�$��0,10,0,0q�$	��Top=�  -   $ Folder=�$ Open your Addon directory��$
 Hand��$��41,670,333,0q�
 �����$��0��$��2��