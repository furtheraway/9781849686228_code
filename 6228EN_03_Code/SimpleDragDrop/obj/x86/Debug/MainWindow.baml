   M S B A M L   `   `   `  ����  CH03.SimpleDragDrop$    CH03.SimpleDragDrop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��40 �6   �� 5	       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��2q�6   
���   �._�5      �� -   5         ��Name$ _source��5      
�������5      5      �� 5   
   
���   �$��2q�6%   $��2��69   ._�5      � -   5         �Name$ _target��5   7    � 	ItemWidth$ 50��6    � 
ItemHeight$ 50��6'   
��� ��� J� 	AllowDrop . 5      5      �� 5   
   -   5         ��Name$ _allowEllipsesOnly��5   M   $
��10,4q�6   $��Allow ellipses only��6!   $��16(�6?   $��1��6i   5      5      