   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   AddonMaster.GUI"   AddonMaster.GUI.ReportWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  Jcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  -   
�������$��1q�(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  �����   ShowCloseButton .   � 
ResizeMode$ NoResize=�   ShowMinButton .   � SizeToContent$ WidthAndHeight=�
������� � WindowStartupLocation$ CenterOwner=�   ShowTitleBar .  .��� $	��200��$	��370��
�������.+��� $��0,1,0,1q�
�������$��	0,31,0,26q�._��� -    ��Name$ 
TxtContent�� �� AcceptsReturn . 	 �� 
CaretBrush
	 �   �
���iii�
 �� 	MaxLength$

 1000�� �� TextWrapping$
 Wrap=�$	��Top=� J� Opacity$ 1Q�$	��370��
������ $��0q�$��Center=�$
��Left=�$��0,0,0,1q�$	��140������ *OutlinePlain+ �� Mode$ TwoWay=� �� NotifyOnTargetUpdated . ��  J� IsHitTestVisible .  $��20(�$��Leave your Feedback��$��Center=�$
��Left=�$��
84,86,0,86q�
�������$	��203������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ 
TxtContent�� �� Value  .a���  � y�$ Visible=���  �� *IsKeyboardFocused+$ 
TxtContent�� true.a���  � y�$ 	Collapsed=��� -   $��CheckboxBug��$��
Bug Report��
�������
���iii�$
��Left=�$��	2,177,0,0q�$	��Top=����� " ��.���  �@d�	IsChecked$
 TrueY� ��  �� *	IsChecked+$ CheckboxFeedback�� true.a���  �@d�	IsChecked$ FalseY��� -   $��CheckboxFeedback��$��Feedback��
�������
���iii�$
��Left=�$��
86,177,0,0q�$	��Top=����� " ��.���  �@d�	IsChecked$ FalseY� ��  �� *	IsChecked+$ CheckboxBug��	 False.a���  �@d�	IsChecked$
 TrueY�"  FontAwesome.WPF.ImageAwesome  -     Name$ ImgSend�� � Cursor$
 Hand�� � ToolTip$ Send the Feedback��   Icon$
 Send=�$��340,172,9,-1q�   
Foreground
 ���F����� "  .���  � {� .  ��  �� *Text+$ 
TxtContent��  .a���  � {� .  ��  �@J�Opacity$	 0.8Q�  -   $��Spinner��$	 Cog=�   Spin . $y�Hidden=�
 �iii�$	 0.8Q�   SpinDuration$ 2Q�$��307,176,30,2q�  -   $ TimesCircle=�$ Close��$
 Hand��$��340,5,5,172q�
 ����� J� RenderTransformOrigin$ 0.5,0.5&�  -   $ MinusCircle=�$ Minimize��$
 Hand��$��310,5,35,172q�
 �����$ 0.5,0.5&�  -	   $ QuestionCircle=�$
 Help��$
 Hand��$��282,5,65,172q�
 �����$ 0.5,0.5&��� $��Addon Master��
���iii�$
��Bold"�$
��Left=�$��0,7,0,0q�$	��Top=�