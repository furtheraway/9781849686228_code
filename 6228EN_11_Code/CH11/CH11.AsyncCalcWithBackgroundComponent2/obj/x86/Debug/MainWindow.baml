   M S B A M L   `   `   `  ����&  "CH11.AsyncCalcWithBackgroundWorker3    -CH11.AsyncCalcWithBackgroundWorker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Primes Counter��5   	    � 
ResizeMode$ CanMinimize=�6     � SizeToContent$ WidthAndHeight=�69   .��5      � $��16(�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��6q�6.   .+�5      �� $��From:��6   �� 5      -   5         ��Name$ _from��5   C   $��10,2,2,2q�6   $	��120��6(    �� 	MaxLength$ 10��64   6C   �� 5      $	��To:��6   $��20,0,0,0q�6#   �� 5      -   5        $	 _to��5   C   $��10,2,2,2q�6   $	��120��6(   $ 10��64   6C   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��6q�6;   .+�5      �� -   5         ��Name$ _calcButton��5   I   $��	Calculate��6   $��4q�6)   6I   �� 5      -   5        $ _cancelButton��5   C   $��Cancel��6   $��4q�6&   $��10,0,0,0q�6Z   {�.  6l   5      � 5   
   -   5         �Name$ 	_progress��5      $��2��6)   $��30��66   $��4q�6B   �� 5   
   -   5        	 ��Name$	 _result��5      $��3��6%   $��6q�62   $��Center=�5      $��20(�61   5      5      