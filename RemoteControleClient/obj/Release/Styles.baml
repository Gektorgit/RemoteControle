   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   GlassButtonOne  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName  GlassButtonTwo � 	Resources  Key g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value � RowDefinitions J� Opacity �� RelativeTransform �� ScaleX �� ScaleY �� AngleX �� AngleY �� Angle T� X T� Y � Color � Offset �� EndPoint �� 
StartPoint N� EnterActions  	Timeline1  N� ExitActions! ��Name  	Timeline2  GlassButtonThree" J� RenderTransformOrigin# ��Name$ �� Triggers	% W� To& g� Duration  GlassButtonFour3   -System.Windows.Media.Effects.DropShadowEffect'    Color(    	Direction)    ShadowDepth*    
BlurRadius+    Opacity, �� CenterX- �� CenterY  GlassButtonFive  GlassButtonSix 	 GlassTextBoxOne-  'System.Windows.Input.KeyboardNavigation. ��Name 
 GlassTextBoxTwo  GlassTextBoxThree  GlassTextBoxFour  GlassTextBoxFive  GlassTextBoxSeven  GlassTextBoxSix  CusomWindow  MainWindowBorderBrush  MainWindowBackgroundBrush/ ��Name0 � Cursor1 �� Color2 � Title3 ��Name  
FlatButton  MainWindowTitleBarSeparator  
btn3DStyle4 �� 	Resources5 W� From6 g� DecelerationRatio7 g� AccelerationRatio  Spin8 '� Camera9 � Position: � LookDirection; g� Content< t� 	Direction= g� 	Transform> �� Rotation? �� Axis@ �� AngleA �� ScaleXB �� ScaleYC �� ScaleZD �� CenterXE �� CenterYF �� CenterZG � MaterialH u� BrushI j� ViewportUnitsJ �� 	TransformK !� VisualL �� PathM �� RelativeSourceN � GeometryO k� 	PositionsP k� TriangleIndicesQ k� TextureCoordinates  GrayBlueGradientBrush   MyGlassGradientStopsResource  MyGlassBrushResourceR �� Opacity  BbButtonS �� RadiusXT �� RadiusYU J� BitmapEffectV �� TextAlignmentW �� RadiusX :� RoutedEvent	Y W� ByZ �� BeginStoryboardName  controlButtonTemplate[ A�Name\ ��Name  controlButtonTemplate2  CustomHeaderStyle�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %,<  &	        &	 |    7  7  &	 �    &	 �	    &	 �    &	     &		 �    &	
 �    &	 '    &	 b    &	 �    &	 �    &	 #    &	 B&    &	 4*    7  &	 �/    &	 l0    &	 31    7  &	 \1    7  7  &	 �7    &	 9    &	 �:    �� "  ��.���  �@J�SnapsToDevicePixels . ��  � ��$ Calibri)���  � ��$ 45(���  � ��
 �   ���  �@J�Opacity$ 1Q���  � �� �� " ��.R��� $ bd��#��z��
����ح�$��1q�$ 	15,0,15,0��._��� #��z��#��z��#��z��# z ��.  P�  �@J�IsMouseOver	 . . ��� $
 bd�� � ��
 �������  � ��
 ������� "  ��.���  � ��$ 
Bauhaus 93)���  � ��$ 45(���  � ��
 �������  �@J�Opacity$ 1Q���  � �� �� " �� ���� 	Timeline1 .��U� $ 00:00:00X�$
 glow��$ (UIElement.Opacity)�.\��� $ 00:00:00.3000000��$ 1Q��� 	Timeline2 .��U� $ 00:00:00X�$
 glow��$ (UIElement.Opacity)�.\��� $ 00:00:00.3000000��$ 0Q�.R��� ���	#FFFFFFFF$��1,1,1,1q�$ 4,4,4,4��._��� $ border�����	#7F000000���	#FF000000$��1,1,1,1q�$ 4,4,4,4��._��  �� $��0.507* ��� $��0.493* �.+��� $
 glow��$ 0Q�$��Stretch=�$
��Auto��$��2��$ 4,4,4,4����
�  V� .~��� $ 1.702Q�$ 2.243Q��� $ 0Q�$ 0Q��� $ 0Q�T� $ -0.368Q�$ -0.152Q�.��� $ 	#B28DBDFF��$ 0Q�� $ 	#008DBDFF��$ 1Q��� $��Center=�$��Center=�$
��Auto��$��2���� $ shine��$��Stretch=�$��0,0,0,0q�$
��Auto��$ 4,4,0,0������ $ 0.494,0.889&�$ 0.494,0.028&�.��� $ 	#99FFFFFF��$ 0Q�� $ 	#33FFFFFF��$ 1Q� P�  � ��	 . . ��� $
 shine�� �@J�Opacity$	 0.4Q��� $
 border�� � �� �	#CC000000�� $

 glow�� � y�$ Hidden=�P�  �@J�IsMouseOver	 .  �� 8��    �� $! Timeline2_BeginStoryboard��8�� �� "  ��.���  � ��$ 
Bauhaus 93)���  � ��$ 45(���  � ��
 �������  � �� �� " ��.R��� $ ButtonBorder��$ 25,25,25,25�����#80AF00$��4,4,4,4q�
�������$" 0.5,0.5&�._��  �� $��* ��� $
��1.7* �.+��� $��0��$ 	23,23,0,0������ $ 0.5,0&�$ 0.5,1&�.��� $ 	#08FFFFFF��$ 0Q�� $ 	#88FFFFFF��$ 1Q��� $# ButtonContentPresenter��$��Center=�$��2��$��Center=� P�  �@J�IsMouseOver	 . P�  � ��	 . . ��� $
 ButtonBorder�� � z� V� .~��� $	 0.9Q�$	 0.9Q���  �@J�Opacity$	 0.5Q�$ P�  �@J�IsMouseOver	 .  �� .���� .��W� $ Opacity�$	% 0.5X�$& 0:0:001D�  �� .���� .��W� $ Opacity�$% 1X�$& 0:0:001D��� "  ��.���  � ��$ 
Bauhaus 93)���  � ��$ 45(���  � ��
 �   ���  �@J�Opacity$ 1Q���  �@J�Effect    $' Black��$	( 320Q�$) 3Q�$* 5Q�$	+ 0.5Q���  � �� �� " ��.R��� $��iBorder��
���   �$��2q�z��� $ 3Q�$, 30Q�$- 3Q�._�� $��iGrid��z��� $ 5Q�$, 45Q�$- 5Q�.+��� $# ButtonContentPresenter��$��Center=�$��2��$��Center=� P�  �@J�IsMouseOver	 . . ��� $
 iBorder�� � ��
 �����P�  � ��	 . . ��� $
 iBorder�� � z� V� .~��� $
 0.95Q�$
 0.95Q��� "  ��.���  � ��$ 
Bauhaus 93)���  � ��$ 45(���  � ��
 �������  �@J�Opacity$ 1Q���  � �� �� " ��.R��� $ ButtonBorder��$ 25,25,25,25�����#80AFFF$��4,4,4,4q�
�������$" 0.5,0.5&�._��  �� $��* ��� $
��1.7* �.+��� $��0��$ 	23,23,0,0������ $ 0.5,0&�$ 0.5,1&�.��� $ 	#08FFFFFF��$ 0Q�� $ 	#88FFFFFF��$ 1Q��� $# ButtonContentPresenter��$��Center=�$��2��$��Center=� P�  � ��	 . . ��� $
 ButtonBorder�� � z� V� .~��� $	 0.9Q�$	 0.9Q��� "  ��.���  � �� �#373737��  � ��
 �������  � ��$ 45(���  �@J�SnapsToDevicePixels . ��  � �� �� " ��.R��� $ 4��#��z��._�� .+��� $# MyContentPresenter��#��z��$��Center=�$��Center=�$��0,0,0,0q� P�  �@J�IsMouseOver	 . . ���  � �� �#E59400��  � ��
 �����P�  � ��	 . . ���  � ��
 � E����  � ��
 ������� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���   �$��2q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 �/����� $
 Border�� � ��
 �   ���  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � ��
 ��ح���  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���iii�$��4,4,4,4q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 �iii��� $
 Border�� � ��
 �iii���  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � ��
 �iii���  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���2�2�$��4,4,4,4q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 �/����� $
 Border�� � ��
 �/�����  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � �� �#80AF00��  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���   �$��2q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 �/����� $
 Border�� � ��
 �   ���  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � ��
 �   ���  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20�����#80AFFF$��4,4,4,4q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � �� �#80AFFF�� $
 Border�� � ��
 �   ���  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � �� �#80AFFF��  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���   �$��4,4,4,4q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 ������� $
 Border�� � ��
 �/�����  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � �� �#80AF00��  � ��
 �   ��� "  ��.���  � ��$ Arial)���  � ��$ 35(���  � ��
 �   ���  �@��TextAlignment$
 Left=���  �@��TextWrapping$ NoWrap=���  � ��$ 	10,5,10,5q���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � �� �� " ��.R��� $��Border��$ 	0,20,0,20��
���   �$��2q�
�������$" 0.5,0.5&�._��� $. PART_ContentHost��$��0q� P�  � {�	 .  . ��� $
 Border�� � ��
 �/����� $
 Border�� � ��
 �   ���  � ��
 �����P�  � {�	 . . ��� $
 Border�� � ��
 ������� $
 Border�� � ��
 �   ���  � ��
 �   ��� "  �.���  � ��# � ����  � �� �� " �.R�� .+��� $ 
MainBorder��#���  $��1q�$ 2��#���  ._�]� ��. .+��� $/ PART_LEFT_BORDER��$��2��$0 SizeWE������ $1 Transparent���� $/ PART_RIGHT_BORDER��$0 SizeWE��$��2��$��Right=����� $1 Transparent���� $/ PART_TOP_BORDER��$0 SizeNS��$	��Top=�$��2������ $1 Transparent���� $/ PART_BOTTOM_BORDER��$0 SizeNS��$��2��$��Bottom=����� $1 Transparent���� $ PART_TITLEBAR��$��2,0,2,2q�$��40��$	��Top=�$ 2��
������ ._�]� ��.  .+��� $��8,0,0,4q�$��Center=�$��UltraExpanded&�
�������$��CharacterEllipsis=�$��NoWrap=�#��z2 $��16(��� $3 
PART_CLOSE��$��Right=�#���  $��Center=�$��0,0,4,0q�.���� .��X�� $3 PART_MAXIMIZE_RESTORE��$��Right=�$��Center=�$��Center=�#���  .���� .��O�� $3 PART_MINIMIZE��$��Center=�#���  $��Center=�$��Right=�.���� .��-�� $��1��$	��Top=�#���  �� $��Bottom=�.u��� �� "  ��4 ���� Spin .��W� $ CubeRotation��$ Angle�$ 0:0:0X�$& 0:0:1D�$5 0X�$	% 360X�$	6 0.5Q�$	7 0.5Q�W� $ CubeRotation��$ Angle�$ 0:0:1X�$& 0:0:1D�$	5 360X�$% 0X�$	6 0.5Q�$	7 0.5Q�W� $ 	CubeScale��$ ScaleX�$ 0:0:0X�$& 0:0:1D�$	5 0.5X�$
% 0.75X�W� $ 	CubeScale��$ ScaleX�$ 0:0:1X�$& 0:0:1D�$
5 0.75X�$	% 1.0X�W� $ 	CubeScale��$ ScaleY�$ 0:0:0X�$& 0:0:1D�$	5 0.5X�$
% 0.75X�W� $ 	CubeScale��$ ScaleY�$ 0:0:1X�$& 0:0:1D�$
5 0.75X�$	% 1.0X�W� $ 	CubeScale��$ ScaleZ�$ 0:0:0X�$& 0:0:1D�$	5 0.5X�$
% 0.75X�W� $ 	CubeScale��$ ScaleZ�$ 0:0:1X�$& 0:0:1D�$
5 0.75X�$	% 1.0X�.���  � ��$	 100����  � ��$	 100����  � �� ��  P�  �@J�IsMouseOver	 .  �� 8��  .R�'� 8 =� $9 4,4,41�$: -1,-1,-15�x�g� ; t� $< -0.3,-0.4,-0.55�g� Cube��= Y� .��� > �� CubeRotation��$? 1,2,35�$@ 0Q��� 	CubeScale��$A 1Q�$B 1Q�$C 1Q�$D 0Q�$E 0Q�$F 0Q�; � OB_Cube��G u� H !� $I Absolute=�$J 1,0,0,-1,0,1W�K �� ���� $L 
Background�M �� *TemplatedParent+._��� $
��Bold"�$��48(����� $L Content�M �� *TemplatedParent+N k� ME_Cube��QO �   .P �$     	

9Q �   �� $	 0,0&�$	 1,1&�.��� $ DarkGray��$ 0Q�� $ #CCCCFF��$	 0.5Q�� $ DarkGray��$ 1Q�� � $ 
WhiteSmoke��$	 0.2Q�� $ Transparent��$	 0.4Q�� $ 
WhiteSmoke��$	 0.5Q�� $ Transparent��$
 0.75Q�� $ 
WhiteSmoke��$	 0.9Q�� $ Transparent��$ 1Q��� $	 0,0&�$	 1,1&�$
R 0.75Q�8��  �� "  ��.���  � ��8   ��  � ��$ 80����  � ��$ 10q���  � �� �� " ��.R�� #��z��#��z��}�. .+��� $/ outerRectangle��$��Stretch=�$��Stretch=�#��z��$S 20��$T 20��$��5��
������ �� $/ innerRectangle��$��Stretch=�$��Stretch=�
������ $��20��#��z��$S 20��$T 20���� $/ 	glassCube��$��Stretch=�$��Stretch=�$��2��$S 10��$T 10��$ 0Q�8�� $" 0.5,0.5&����� $ 0.5,0&�$ 0.5,1&���� $	 0.0Q�$ 	LightBlue��� $	 1.0Q�$
 Gray��z�V� .~��� �� U �� ]� $!��myContentPresenterDockPanel��.+��� $# myContentPresenter��$��20q�#��z��
���   �$V Center=�$��24(� P�  �@J�IsMouseOver	 . . ��� $
 outerRectangle��# � �� � ���� $
 	glassCube�� �@J�Opacity$ 1Q��� $
 myContentPresenter�� �@J�BitmapEffect �� $W 1Q�P�  �@J�	IsFocused	 . . ��� $
 	glassCube�� �@J�Opacity$ 1Q��� $
 outerRectangle��# � �� � ���� $
 	glassCube�� �@J�Opacity$ 1Q�:� $X Mouse.MouseEnter��[��� $! mouseEnterBeginStoryboard��.���� .��W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
Y -0.1X�$& 0:0:0.5D�W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
Y -0.1X�$& 0:0:0.5D�:� $X Mouse.MouseLeave��[��� $Z mouseEnterBeginStoryboard��:� $X Button.Click��[��� .���� .��W� $ 	glassCube��$V P(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)�$	Y 360X�$& 0:0:0.5D��� "  ��.���  � �� �� .R�� .+�A� $[ outerCircle��$
��Auto��$
��Auto��$��4��
����ح�
��� d ��� $\ content��$��Center=�$��Center=�
����  ����� $L Content�M �� *TemplatedParent+ P�  �@J�IsMouseOver	 . . ��� $
 outerCircle�� � ��
 �2�2��� $
 content�� � ��
 ������� "  ��.���  � �� �� .R�� .+��� $/ outerCircle��$	 0.2Q�$
��Auto��$
��Auto��$��4��
�������
���   ��� $\ content��$��24(�$��Center=�$��Center=�
��� ������� $L Content�M �� *TemplatedParent+ P�  �@J�IsMouseOver	 . . ��� $
 outerCircle�� � ��
 �   ��� $
 content�� � ��
 ������� "  ��.���  � �� �	#FFCDE7F4��  � �� �	#FF07034B��  � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFA1CCE0��$ 0Q�� $ 	#FFABD5EA��$	 1.0Q�