   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI    AddonMaster.GUI.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5        
�������$��1q�5	      
�������(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � 
ResizeMode$ CanMinimize=�5   @      ShowMinButton .     ShowCloseButton .   � SizeToContent$ WidthAndHeight=�6�      ShowTitleBar .     ShowMaxRestoreButton .   � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5       !  ListBoxtemStyleNoHighlighting	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name��%�   &	        �� 5   
   "	 ��66   .�5      �� 
 � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ contentPresenter��6/   6K   5      5      5      5      5      .��5      � $	��700��6   $	��400��6   
������� � RowDefinitions 5   
   �� 5      $	��27* �6   �� 5      .+�5   
   �� 
�������$
��Left=�6'   $��	0,665,0,0q�6B   $	��Top=�6U   $��35��6m   $	��400��6y   $��2��6�   �� 5   
   -   5         ��Name$ LblAddonList��5      #��[  6(   $��Stretch=�6l   $��	0,34,0,10q�6�   
�������$��0,1,0,1q�6�   
������ ��5       �� 5!      .R�5"      �� 
�������$��2,3,2,0q�65   $��1q�6F   ._�5#      � $��0q�6   
������� � ColumnDefinitions 5$      �� 5%   "   $��30 �63   �� 5&   "   $��10 �63   �� 5'   "   $��* �63   �� 5(   "   $��60 �63   �� 5)   "   $��30 �63   �� 5*   "   $��30 �63   �� 5+   "   $��30 �63   .+�5-      �� -   5        $��30��5-   $   $��0��60   ��6]   �� *Image+ � ToolTip 6v   �� *Description+�� 5.      $��1��6$   �� 5/      -   5        $	��Top=�5/   (   
���   �$��2��6p   ��6�   �� *Name+ 6�   �� *Description+�� 50      -   5        $��Bottom=�50   (   
�������$��11(�6U   $��2��6�   ��6�   �� *Patch+"  FontAwesome.WPF.ImageAwesome  51        Name$ Spinner��69      Icon$	 Cog=�6.      
Foreground
 �iii�$��4��6�      Spin . $��22��6�      SpinDuration$ 2Q�6�   $��2��6�   y�6J   �� *UpdateCogVisibility+53        54      $ 	imgUpdate��6=   -   5        $ Refresh=�54   .   $ Update addon��6P   $��5��6g    � Cursor$
 Hand��6w   
 ���F�$��22��6�   6�     55      $ 	imgRemove��6A   -   5        $ MinusCircle=�55   .   $ Remove addon��6T   $��6��6k   
 �\\��$
 Hand��6�   $��24��6�   6�   56      57      58      5:        5;   
   -   5        $ ImgAdd��5;   U   $ 
PlusCircle=�6   $ Install an addon��6,   $
 Hand��6G   $��364,669,5,3q�6�   
 ���F�$��2��6�   �� 5<   
   -	   5         ��Name$ LblEmptyList��5<   4   $��Center=�6   $-��'Use the blue button to install an addon��6J   
�������$��20(�6�   $��11,290,10,237q�6�     5=   
   -
   5        $	 Bug=�5=      $# Report a bug or give feedback��6%   $
 Hand��6M   $��5,670,371,2q�6{   
 �����$��2��6�     5>   
   -   5        $ TimesCircle=�5>      $ Close��6-    J� Opacity$ 1Q�6=   $
 Hand��6I   $��371,5,5,646q�6z   
 �����6�     5?   
   -   5        $ MinusCircle=�5?      $ Minimize��6-   $ 1Q�6@   $
 Hand��6L   $��341,5,35,646q�6}   
 ����� J� RenderTransformOrigin$ 	1.66,0.85&�6�     5@   
   -   5        $ QuestionCircle=�5@      $
 Help��60   $ 1Q�6?   $
 Hand��6K   $��312,5,64,646q�6|   
 �����6�   �� 5A   
   $��Addon Master��6   
���iii�$
��Bold"�6<   $
��Left=�6N   $��0,10,0,0q�6i   $	��Top=�6{     5B   
   -   5        $ Folder=�5B      $ Open your Addon directory��6(   $
 Hand��6L   $��41,670,333,0q�6   
 �����$��2��6�   5C      5D      