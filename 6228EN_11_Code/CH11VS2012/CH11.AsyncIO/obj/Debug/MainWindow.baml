   M S B A M L   `   `   `  ����  CH11.AsyncIO    CH11.AsyncIO.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Async I/O Demo��5   	   $	��350��6    $	��525��6-   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��16(�6.   .+�5      �� -   5        $��Get Data (sync)��5      $��4q�6/   6:   �� 5      -   5        $��Get Data (async old)��5      $��4q�64   6?   �� 5      -   5        $��Get Data (async new)��5      $��4q�64   6?   �� 5      -   5        $��Get Data (w/ Timeout)��5      $��4q�65   6@   5      �� 5   
   -   5         ��Name$ _result��5   _    �� 
IsReadOnly . $��1��6$   $��4q�61   $��12(�6<    �� AcceptsReturn . 6_   5      5      