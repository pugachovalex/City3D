# Holographic Spatial Visualizations to Assist Identifying Irregular Power Usage

##Problem description 

This demo was created during my internship at SnT, University of Luxembourg, in addition to the paper "Identifying Irregular Power Usage by Turning Predictions into Holographic Spatial Visualizations" [1]. The work refers to identifying non-technical losses (NTL) in the power grids. They include, but are not limited to, the following causes:
• Meter tampering in order to record lower consumptions
• Bypassing meters by rigging lines from the power source
• Arranged false meter readings by bribing readers
• Faulty or broken meters [1].   

Authors utilized a machine learning approach to tackle this problem. More details (description of data, feature selection, feature extraction, selection of models, evaluation) can be found in the paper [1]. Here I would like to give a short overview about holographic visualization with Hololens. 

The NTL detection approach allows to predict whether customers cause NTL or not. It can then be used to trigger possible inspections of customers that have irregular electricity consumption patterns. Subsequently, technicians carry out inspections, which allow them to remove possible manipulations or malfunctions of the power distribution infrastructure [1]. However, carrying out inspection can be costly. Therefore, visualization approach of the  meter aims to help domain experts to alleviate making the final decisions of which customers to inspect. Spheres, which represent customers, has been marked according to the classifier. By navigating, domain expert can click on the customer, see yearly consumption meter data and corresponding graph. This helps to make a more awared decision about sending inspection to the customers and provide addition check to the validity of the model results. 

## Augmented Reality Visualization

A core of visualization is to locate customers in 3D space, navigate among them by using gaze and see relevant information by clicking. For this demo, 3D map of a part of Luxembourg city was reconstructed from Google Earth View. The map conforms a district from which real data has been collected. 



##Reference
[1] P. Glauner, N. Dahringer, O. Puhachov, J. Meira, P. Valtchev, R. State and D. Duarte, "Identifying Irregular Power Usage by Turning Predictions into Holographic Spatial Visualizations", Proceedings of the 17th IEEE International Conference on Data Mining Workshops (ICDMW 2017), New Orleans, USA, 2017. (https://arxiv.org/abs/1709.03008)
