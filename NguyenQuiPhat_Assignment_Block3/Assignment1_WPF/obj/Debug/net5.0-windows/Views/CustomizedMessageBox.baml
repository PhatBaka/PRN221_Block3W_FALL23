   M S B A M L   `   `   `  ����  Assignment1_WPF0    *Assignment1_WPF.Views.CustomizedMessageBox   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5        $	��200��5   	   $	��400��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #462AD8��6#   	 � Offset$	 0Q�63   � 5      $ #DA34AE��6#   $
	 0.75Q�63   � 5      $ #8A16C1��6#   $	 1Q�63   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $ #060531��6#   $	 0Q�63   � 5       $ #1B1448��6#   $	 1Q�63   5!      ._�5$      � 
 � RowDefinitions
 5%      �� 5&      $��30 �6$   �� 5'      .+�5*      � $��0��6    � ColumnDefinitions 5,      �� 5-      �� 5.      $��25 �6+   �� 5/      $��25 �6+   �� 50      $��5 �6+   .+�5U      �� -   5         ��Name$ btnClose��5U      $��0q�5V      $��X��5W      
�������$��12(�5Y      $��
Montserrat)�5Z       � Cursor$
 Hand��5[      $��2��5\      ��5_      �� 5`       �� 
TargetType" ��6$   .�5a   "   ��  �� Property � �� �� Value �#DA34AE6?    �� Triggers 5b   "   P� 5c   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5d   *   ��  � �� �#C62DAE6G   5e   '   5g      ��5j      �� 5k       �� 
TargetType" ��6.   .R�5l   "   �� $��18��6)   $��18��64   $ 9��5m   )   #��z��5n   )   ._�5o   &   �� $��Center=�67   $��Center=�5p   7   5q   #   5r      5t      5u      �� 5w      $	��350��6   $��1��5x       �� Orientation$ Vertical=�5y      $��0,35,0,0q�5z      .+�5|      �� -   5         ��Name$ 	tbMessage��5|       $J��DLearning to code is useful no matter what your career ambitions are.��5}       
�������$��20(�5       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       5�      5�      5�      5�      5�      